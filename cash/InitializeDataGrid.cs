using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cash
{
    class InitializeDataGrid()
    {
        public static void Initialize(DataGridView grid)
        {
            grid.Columns.Add("Nominal", "Номінал");
            grid.Columns.Add("Quantity", "Кількість");
            grid.Columns.Add("Sum", "Сума");
            grid.Columns[0].ReadOnly = true;
            grid.Columns[2].ReadOnly = true;
            decimal[] nominals = { 1000m, 500m, 200m, 100m, 50m, 20m, 10m, 5m, 2m, 1m, 0.5m, 0.25m };
            foreach(var nominal in nominals) grid.Rows.Add(nominal, 0 ,0);
        }
    }
}
