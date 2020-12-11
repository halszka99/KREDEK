using System.Data;

namespace HalszkaCiesielskaZad3
{
    interface IPositionsRepository
    {
        DataTable GetPositions();
        DataSet GetPositionsNames(); 
    }
}
