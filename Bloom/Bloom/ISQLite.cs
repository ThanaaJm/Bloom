using System;
using System.Collections.Generic;
using System.Text;

namespace Bloom
{
        public interface ISQLite
        {
            SQLite.SQLiteConnection GetConnection();

        }
}
