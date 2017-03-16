using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ModbusTcp
{
    public class Enums
    {
        public enum ModbusFunctionTypes
        {
            ReadCoils = 0x01, ReadDiscreteInputs = 0x02, ReadHoldingRegisters = 0x03, ReadInputRegisters = 0x04
        }

        public enum ModbusMemoryType
        {
            Coils = 0, DiscreteInputs = 1, InputRegisters = 3, HoldingRegisters = 4
        }

        public enum ModbusExceptionCode
        {
            IllegalFunction = 0x01, IllegalDataAddress = 0x02, IllegalDataValue = 0x03, SlaveDeviceFailure = 0x04, Acknowledge = 0x05,
            SlaveDeviceBusy = 0x06, NegativeAcknowledge = 0x07, MemoryParityError = 0x08, GatewayPathUnavailable = 0x0A,
            GatewayTargetDeviceFailedToRespond = 0x0B
        }

        public enum ModbusIndex
        {
            TransactionId_1st = 0, TransactionId_2nd = 1, ProtocolId_1st = 2, ProtocolId_2nd = 3, Length_1st = 4, Length_2nd = 5,
            UnitId = 6, FunctionCode = 7, StartAddress_1st = 8, StartAddress_2nd = 9, NumbersToRead_1st = 10, NumbersToRead_2nd = 11,
            ResponseByteLength = 8, ExceptionCode = 8, ResponseData_1st = 9, ResponseData_2nd = 10
        }

        public enum StartMode
        {
            ServerMode = 0, ClientMode = 1
        }
    }
}
