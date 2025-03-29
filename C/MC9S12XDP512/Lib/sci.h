// Serial Communications Interface
// Jonathan Le
// 2025-03-13

#define BUFFER_SIZE 64

void SCI_Init(unsigned long ulBaudRate);
void sci0_txByte (char txByte);
void sci0_txStr (char* strIndex);
unsigned char sci0_rxByte(char* pRxByte);
// void ClearBuffers(void);
// void ClearTxBuffer(void);
// void ClearRxBuffer(void);


/************************Variable Inits***************************/
/*
char rxByte = 0;
char rxBuffer[BUFFER_SIZE];
int rxIndex = 0;
char txBuffer[BUFFER_SIZE];
int txIndex = 0;
int endOfMessageReceived = 0; //for rti function
*/
