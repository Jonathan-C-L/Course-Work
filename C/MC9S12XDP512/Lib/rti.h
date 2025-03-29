//real time interrupt library
//Jonathan Le
//March 6, 2025
extern volatile unsigned long rtiMasterCount;

void RTI_Init(void);
void RTI_Delay_ms(unsigned long delay);