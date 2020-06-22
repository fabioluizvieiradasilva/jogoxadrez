using System;

namespace Tabuleiro
{
    class TableException:Exception
    {
        public TableException(string msg): base(msg)
        {

        }
    }
}
