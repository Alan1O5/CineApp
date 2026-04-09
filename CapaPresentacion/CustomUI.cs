using System;
using System.Drawing;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public static class CustomUI
    {
        // 1. Definimos una paleta de colores elegante (Estilo "Cine Dark Mode")
        private static Color BackgroundColor = Color.FromArgb(32, 34, 37); // Fondo principal (Gris oscuro carbón)
        private static Color PanelColor = Color.FromArgb(47, 49, 54);      // Fondo secundario (Gris un poco más claro)
        private static Color AccentColor = Color.FromArgb(183, 28, 28);    // Rojo Cine (Deep Red)
        private static Color AccentHover = Color.FromArgb(220, 53, 69);    // Rojo encendido al pasar el mouse
        private static Color TextColor = Color.FromArgb(240, 240, 240);    // Blanco humo para no cansar la vista
        private static Color InputColor = Color.FromArgb(64, 68, 75);      // Fondo oscuro para las cajas de texto

        public static void LoadDefaultStyle(Form actualForm)
        {
            actualForm.BackColor = BackgroundColor;
            actualForm.ForeColor = TextColor;
            actualForm.FormBorderStyle = FormBorderStyle.FixedSingle;
            actualForm.StartPosition = FormStartPosition.CenterScreen;


            ApplyThemeRecursively(actualForm.Controls);
        }

        private static void ApplyThemeRecursively(Control.ControlCollection controls)
        {
            foreach (Control control in controls)
            {
                if (control.HasChildren)
                {
                    ApplyThemeRecursively(control.Controls);
                }

                if (control is Button btn)
                {
                    btn.FlatStyle = FlatStyle.Flat;
                    btn.FlatAppearance.BorderSize = 0;
                    btn.BackColor = AccentColor;
                    btn.ForeColor = Color.White;
                    btn.Font = new Font("Segoe UI Semibold", 9.5F, FontStyle.Bold);
                    btn.Cursor = Cursors.Hand;

                    btn.FlatAppearance.MouseOverBackColor = AccentHover;
                    btn.FlatAppearance.MouseDownBackColor = Color.DarkRed;
                }
                else if (control is TextBox txt)
                {
                    txt.BorderStyle = BorderStyle.FixedSingle;
                    txt.BackColor = InputColor;
                    txt.ForeColor = Color.White;
                    txt.Font = new Font("Segoe UI", 10.5F, FontStyle.Regular);
                }
                else if (control is NumericUpDown num)
                {
                    num.BorderStyle = BorderStyle.FixedSingle;
                    num.BackColor = InputColor;
                    num.ForeColor = Color.White;
                    num.Font = new Font("Segoe UI", 10.5F, FontStyle.Regular);
                }
                else if (control is ComboBox cmb)
                {
                    cmb.FlatStyle = FlatStyle.Flat;
                    cmb.BackColor = InputColor;
                    cmb.ForeColor = Color.White;
                    cmb.Font = new Font("Segoe UI", 10.5F, FontStyle.Regular);
                }
                else if (control is Label lbl)
                {
                    if (control.Tag != null && control.Tag.ToString() == "Titulo")
                    {
                        lbl.ForeColor = Color.DarkRed; // Un color más llamativo (Rojo encendido)
                        lbl.Font = new Font("Segoe UI Semibold", 25F, FontStyle.Bold | FontStyle.Italic); // Letra más grande
                        lbl.Paint -= LabelShadow_Paint; // Evitamos duplicar el evento
                        lbl.Paint += LabelShadow_Paint;

                        // Refrescamos para que se aplique el dibujo
                        lbl.Invalidate();
                    }

                    else
                    {
                        lbl.BackColor = Color.Transparent;
                        lbl.ForeColor = TextColor;
                        lbl.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
                    }

                }
                else if (control is DataGridView dgv)
                {
                    dgv.EnableHeadersVisualStyles = false;
                    dgv.BackgroundColor = BackgroundColor;
                    dgv.BorderStyle = BorderStyle.None;

                    dgv.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
                    dgv.GridColor = Color.FromArgb(80, 80, 80);

                    dgv.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
                    dgv.ColumnHeadersDefaultCellStyle.BackColor = AccentColor;
                    dgv.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
                    dgv.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10.5F, FontStyle.Bold);
                    dgv.ColumnHeadersDefaultCellStyle.SelectionBackColor = AccentColor;

                    dgv.DefaultCellStyle.BackColor = PanelColor;
                    dgv.DefaultCellStyle.ForeColor = TextColor;
                    dgv.DefaultCellStyle.Font = new Font("Segoe UI", 10F, FontStyle.Regular);

                    dgv.DefaultCellStyle.SelectionBackColor = Color.FromArgb(115, 20, 20);
                    dgv.DefaultCellStyle.SelectionForeColor = Color.White;
                    dgv.RowHeadersVisible = false;

                    dgv.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(54, 57, 63);
                }
                else if (control is Panel pnl)
                {
                    pnl.BackColor = PanelColor;
                }
                else if (control is GroupBox grp)
                {
                    grp.BackColor = Color.Transparent;
                    grp.ForeColor = AccentHover;
                    grp.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
                }
            }
        }
        private static void LabelShadow_Paint(object sender, PaintEventArgs e)
        {
            Label lbl = (Label)sender;
            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            e.Graphics.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;

            string texto = lbl.Text;
            Font fuente = lbl.Font;

            
            using (Brush sombraBrush = new SolidBrush(Color.Black))
            {
                e.Graphics.DrawString(texto, fuente, sombraBrush, new PointF(3, 3));
            }

           

            // DIBUJAMOS EL TEXTO PRINCIPAL
            using (Brush textoBrush = new SolidBrush(lbl.ForeColor))
            {
                e.Graphics.DrawString(texto, fuente, textoBrush, new PointF(0, 0));
            }
        }
    }

        }
    

