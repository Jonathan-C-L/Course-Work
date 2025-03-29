/********************************************************************/
// HC12 Library:  real time interrupt
// Processor:     MC9S12XDP512
// Author:        Jonathan Le
// Details:       clock functions
//                                
// Date:          March 6, 2025
// Revision History :
//  March 6, 2025 - Initial build


/********************************************************************/
// Library includes
/********************************************************************/
#include <hidef.h>      /* common defines and macros */
#include "derivative.h" /* derivative-specific definitions */
#include "rti.h"

/********************************************************************/
// Global Variables
/********************************************************************/
volatile unsigned long rtiMasterCount = 0;
volatile unsigned int rtiDelayCount;
/********************************************************************/
// Library Functions
/********************************************************************/
void RTI_Init(void)
{
  // RTICTL - Decimal, divider 2000, mod8 counter,
  // results in an exact 1ms tick, independent of
  // buss speed, or code execution speed.
  RTICTL = 0b10010111;
  // CRGINT_RTIE_MASK = 0b10000000
  // Enable real time Interrupt
  CRGINT |= CRGINT_RTIE_MASK; 
}

void RTI_Delay_ms(unsigned long delay)
{
  unsigned long timeout = rtiMasterCount + delay;
  //while(rtiMasterCount != timeout);
  while(timeout - rtiMasterCount > 0);
}
/********************************************************************/
// Another group of library functions
/********************************************************************/


/********************************************************************/
// Another title placeholder
/********************************************************************/


/********************************************************************/
// Interrupt Service Routines Template
/********************************************************************/
/*

interrupt VectorNumber_Vrti void Vrti_ISR(void)
{
  // Clear flag so interrupt can happen again.
  CRGFLG = CRGFLG_RTIF_MASK;
  // Perform some actions here...
  rtiMasterCount++;
  // Toggle Green led to show that this interrupt
  // is working, it will toggle every 300 times
  // that this ISR runs, or every 300ms.
  if((rtiMasterCount % 300) == 0){
    SWL_TOG(SWL_GREEN);
  }
}
  
*/