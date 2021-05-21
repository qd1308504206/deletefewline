using System.Windows.Forms;

namespace DeleteFirstFewLine
{
    public class MyForm
    {
        public static void DeleteSelectedRows(ref DataGridView DGV)
        {
            if (DGV.Rows.Count < 1 || DGV.SelectedRows.Count < 1)
            {
                return;
            }

            for (int i = DGV.SelectedRows.Count; i > 0; i--)
            {
                DGV.Rows.RemoveAt(DGV.SelectedRows[i - 1].Index);
            }
        }
    }
}
