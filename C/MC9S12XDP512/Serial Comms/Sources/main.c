/********************************************************************/
// HC12 Program:  SCI using library with sprintf and sscanf
// Processor:     MC9S12XDP512
// Bus Speed:     8 MHz
// Author:        Jonathan Le
// Details:       Program will allow the user to change the delay (in ms) 
//                  via interaction with the buttons or text input in Tera Term               
// Date:          March 22, 2025
// Revision History : 
//  March 22, 2025 - project started
//  March 23, 2025 - project completed



/********************************************************************/
// Library includes
/********************************************************************/
#include <hidef.h>      /* common defines and macros */
#include "derivative.h" /* derivative-specific definitions */
#include <string.h>
//Other system includes or your includes go here
//#include <stdlib.h>
#include <stdio.h>
#include "sw_led.h"
#include "sci.h"
#include "rti.h"
#include "clock.h"

/********************************************************************/
//Defines
/********************************************************************/

/********************************************************************/
// Local Prototypes
/********************************************************************/
void PartC(void);
void ClearBuffers(void);

/********************************************************************/
// Global Variables
/********************************************************************/
char rxByte = 0;
char rxBuffer[BUFFER_SIZE];
int rxIndex = 0;
char txBuffer[BUFFER_SIZE];
int txIndex = 0;
int endOfMessageReceived = 0;
int delay = 50;
SwState leftState, centerState, rightState, upState, downState = Idle;
/********************************************************************/
// Constants
/********************************************************************/

/********************************************************************/
// Main Entry
/********************************************************************/
void main(void)
{
  //Any main local variables must be declared here

  // main entry point
  _DISABLE_COP();
  EnableInterrupts;
  
/********************************************************************/
  // one-time initializations
/********************************************************************/
SWL_Init();
//testing out bus speed calculations
Clock_Set34MHZ();
RTI_Init();
SCI_Init(9600);
/********************************************************************/
  // main program loop
/********************************************************************/
PartC();
                  
}

/********************************************************************/
// Functions
/********************************************************************/
void ClearBuffers(void){
  // Clear rxBuffer with 0's for next received message.
  for(rxIndex=0; rxIndex<BUFFER_SIZE; rxIndex++){
    rxBuffer[rxIndex] = 0;
  }
  // Reset rxIndex to 0 for next received message.
  rxIndex = 0;
  // Clear txBuffer with 0's for next transmitted message.
  for(txIndex=0; txIndex<BUFFER_SIZE; txIndex++){
    txBuffer[txIndex] = 0;
  }
  // Reset txIndex to 0 for next transmitted message.
  txIndex = 0;
}

void PartC(void){
  int jobDone = 0;
  int isNumber = 1;
  int newPotentialDelay;
  for (;;)
  {
    //checking button states ahead of time 
    Sw_State(&centerState, SWL_CTR);
    Sw_State(&upState, SWL_UP);
    Sw_State(&downState, SWL_DOWN);

    if((rtiMasterCount % delay) == 0 && jobDone == 0){
      SWL_TOG(SWL_RED);
      jobDone = 1;
    }
    if((rtiMasterCount % delay) != 0){
      jobDone = 0;
    }
    if(centerState == Pressed){
      break;
    }
    //PartB - up and down buttons can increment/decrement delay
    if(upState == Pressed)
    {
      //max value validation
      if(delay >= 100){
        sci0_txStr("Delay cannot be >= 100 ms");
        sci0_txStr("\r\n");
      }
      //other incrementing conditions are permissible
      else{
        delay += 10;
        sci0_txStr("Delay increased to ");
        sprintf(txBuffer, " %d", delay);
        sci0_txStr(txBuffer);
        sci0_txStr(" mS");
        sci0_txStr("\r\n");
        ClearBuffers();
      } 
    }   
    if(downState == Pressed)
    {
      //min value validation
      if(delay <= 10){
        sci0_txStr("Delay cannot be <= 0 ms");
        sci0_txStr("\r\n");
      }
      //other decrement conditions are permissible
      else{
        delay -= 10;
        sci0_txStr("Delay decreased to ");
        sprintf(txBuffer, " %d", delay);
        sci0_txStr(txBuffer);
        sci0_txStr(" mS");
        sci0_txStr("\r\n");
        ClearBuffers();
      }  
    }
    //if register is not empty - execute below
    if(endOfMessageReceived)
    {
      endOfMessageReceived = 0;
      isNumber = 1;//default true for input validation
      //input validation if input was a number
      while(rxIndex > 0){
        rxIndex--;
        if(!(rxBuffer[rxIndex] >= '0' && rxBuffer[rxIndex] <= '9')){
          isNumber = 0;//0 is false
        }
      }
      if(sscanf(rxBuffer, "%d", &newPotentialDelay) && isNumber)
      {
        //input can only between 10 and 100
        if(newPotentialDelay < 10 || newPotentialDelay > 100){
          sci0_txStr("Delay NOT changed as new value out of range");
          sci0_txStr("\r\n");
        }
        else{
          delay = newPotentialDelay;
          sci0_txStr("Delay updated to ");
          sprintf(txBuffer, " %d", delay);
          sci0_txStr(txBuffer);
          sci0_txStr(" mS");
          sci0_txStr("\r\n");
        }
      }
      else
      {
        sci0_txStr("Wrong input format. Try again...\r\n");
      }
      ClearBuffers();
    }
  }       
}
/********************************************************************/
// Interrupt Service Routines
/********************************************************************/
interrupt VectorNumber_Vrti void Vrti_ISR(void)
{
  // Clear flag so interrupt can happen again.
  CRGFLG = CRGFLG_RTIF_MASK;
  // Perform some actions here...
  rtiMasterCount++;
  // Toggle Green led to show that this interrupt
  // is working, it will toggle every 50 times
  // that this ISR runs, or every 50ms.
  if((rtiMasterCount % 50) == 0){
    SWL_TOG(SWL_GREEN);
  }
}

interrupt VectorNumber_Vsci0 void Vsci0_ISR(void)
{
  if(sci0_rxByte(&rxByte))
  {
    // Messsage is ended when
    // CR or '\r' is sent from
    // Tera-Term.
    if(rxByte == '\r'){
      endOfMessageReceived = 1;
    }
    else if(rxByte == '\n'){
      // Do Nothing but make sure that
      // Tera-Term sends both a CR and LF
      // when Enter is pressed.
    }
    else if(rxIndex < BUFFER_SIZE){
      // Add received byte to buffer array.
      rxBuffer[rxIndex++] = rxByte;
    }
  }
}