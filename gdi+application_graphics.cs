using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
namespace WindowsFormsApp4{
public partial class Form1 : Form{
public Form1(){
InitializeComponent(); }
private void Form1_Paint(object sender, PaintEventArgs e){
System.Drawing.GraphicsgraphicsObj;
graphicsObj = this.CreateGraphics();
Pen myPen = new Pen(System.Drawing.Color.Green, 5);
Rectangle myRectangle = new Rectangle(20, 20, 250, 200);

graphicsObj.DrawEllipse(myPen, myRectangle);

}
private void Form1_Load(object sender, EventArgs e) {
} }
}
