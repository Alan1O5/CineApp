using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public static class CustomUI
    {
        public static void LoadDefaultStyle(Form actualForm)
        {

            Color primary = System.Drawing.Color.DarkGray;
            Color secondary = System.Drawing.Color.Black;

            actualForm.BackColor = primary;
            foreach (Control control in actualForm.Controls)
            {
                if (control is Button)
                {
                    ((Button)control).FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                    ((Button)control).BackColor = System.Drawing.Color.DarkRed;
                    ((Button)control).Cursor = System.Windows.Forms.Cursors.Hand;
                    ((Button)control).FlatAppearance.BorderSize = 0;
                    ((Button)control).FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                    ((Button)control).Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    ((Button)control).ForeColor = System.Drawing.Color.White;
                }
                else if (control is CheckBox)
                {

                }
                else if (control is RadioButton)
                {

                }
                else if (control is TextBox)
                {
                    ((TextBox)control).BorderStyle = System.Windows.Forms.BorderStyle.None;
                    ((TextBox)control).BackColor = System.Drawing.Color.Gray;
                    ((TextBox)control).Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    ((TextBox)control).ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
                    ((TextBox)control).TabIndex = 2;
                }
                else if (control is Label)
                {
                    ((Label)control).FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                    ((Label)control).AutoSize = true;
                    ((Label)control).Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    ((Label)control).TabIndex = 7;
                }
                else if (control is DataGridView)
                {
                    ((DataGridView)control).BackgroundColor = System.Drawing.Color.DarkGray;
                    ((DataGridView)control).BorderStyle = System.Windows.Forms.BorderStyle.None;
                    ((DataGridView)control).CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
                    ((DataGridView)control).ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.DarkRed;
                    ((DataGridView)control).ColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.Color.White;
                    ((DataGridView)control).ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    ((DataGridView)control).EnableHeadersVisualStyles = false;
                    ((DataGridView)control).RowHeadersVisible = false;
                    ((DataGridView)control).DefaultCellStyle.BackColor = System.Drawing.Color.White;
                    ((DataGridView)control).CellBorderStyle=DataGridViewCellBorderStyle.Single;
                    ((DataGridView)control).GridColor = System.Drawing.Color.DarkRed;
                    ((DataGridView)control).DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
                    ((DataGridView)control).DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                }
                else if (control is ComboBox)
                {
                    ((ComboBox)control).FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                    ((ComboBox)control).BackColor = System.Drawing.Color.White;
                    ((ComboBox)control).Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    ((ComboBox)control).ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
                }
                else if (control is Panel)
                {
                    ((Panel)control).BackColor = System.Drawing.Color.DarkGray;
                }
                else if ((control is Form))
                {
                    ((Form)control).BackColor = System.Drawing.Color.DarkGray;
                    ((Form)control).FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
                    ((Form)control).StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;


                }

            }
        }
    }
}