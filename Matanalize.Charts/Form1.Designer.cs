using System;
using System.ComponentModel;
using OxyPlot;
using OxyPlot.Series;
using OxyPlot.WindowsForms;
using System.Windows.Forms;
using System.Drawing;
using Matanalize.Common;


namespace Matanalize.Charts
    {
    partial class Form1
        {
        private PlotView plot0;
        private PlotView plot1;
        private PlotView plot2;
        private PlotView plot3;
        private PlotView plot4;
        private PlotView plot5;
        private PlotView plot6;

        private int _intervalStart = -5;
        private int _intervalEnd = 5;

        private IContainer components = null;


        protected override void Dispose(bool disposing)
            {
            if (disposing && (components != null))
                {
                components.Dispose();
                }
            base.Dispose(disposing);
            }

        #region Windows Form Designer generated code

        private void InitializeComponent()
            {
            this.components = new Container();
            this.AutoScaleMode = AutoScaleMode.Font;
            this.ClientSize = new Size(800, 450);
            this.Text = "Form1";

            this.plot0 = new PlotView();
            InitializePlotProps(plot0, "a) y=(e^x) sin x", 0);
            InitializePlotModel(plot0, Constants.Function);
            this.Controls.Add(this.plot0);

            this.plot1 = new PlotView();
            InitializePlotProps(plot1, "b) kai imamas narys tik su x0", 1);
            Func<double, double> taylorWithX0 = (double x) => Taylor.GetNthTaylorFormulaCoefficient(0); // will result in a constant 0
            InitializePlotModel(plot1, taylorWithX0);
            this.Controls.Add(this.plot1);

            this.plot2 = new PlotView();
            InitializePlotProps(plot2, "c) kai imami nariai su x0 ir x1", 2);
            Func<double, double> taylorWithX1 = (double x) => taylorWithX0(x) + Taylor.GetNthTaylorFormulaCoefficient(1) * x;
            InitializePlotModel(plot2, taylorWithX1);
            this.Controls.Add(this.plot2);

            this.plot3 = new PlotView();
            InitializePlotProps(plot3, "d) kai imami nariai su x0, x1 ir x2", 3);
            Func<double, double> taylorWithX2 = (double x) => taylorWithX0(x) + taylorWithX1(x) + Taylor.GetNthTaylorFormulaCoefficient(2) * Math.Pow(x, 2);
            InitializePlotModel(plot3, taylorWithX2);
            this.Controls.Add(this.plot3);

            this.plot4 = new PlotView();
            InitializePlotProps(plot4, "d) kai imami nariai su x0, x1, x2 ir x3", 4);
            Func<double, double> taylorWithX3 = (double x) => taylorWithX0(x) + taylorWithX1(x) + taylorWithX2(x) + Taylor.GetNthTaylorFormulaCoefficient(3) * Math.Pow(x, 3);
            InitializePlotModel(plot4, taylorWithX3);
            this.Controls.Add(this.plot4);

            this.plot5 = new PlotView();
            InitializePlotProps(plot5, "d) kai imami nariai su x0, x1, x2, x3 ir x4", 5);
            Func<double, double> taylorWithX4 = (double x) => taylorWithX0(x) + taylorWithX1(x) + taylorWithX2(x) + taylorWithX3(x) + Taylor.GetNthTaylorFormulaCoefficient(4) * Math.Pow(x, 4);
            InitializePlotModel(plot5, taylorWithX4);
            this.Controls.Add(this.plot5);

            this.plot6 = new PlotView();
            InitializePlotProps(plot6, "d) kai imami nariai su x0, x1, x2, x3, x4 ir x5", 6);
            Func<double, double> taylorWithX5 = (double x) => taylorWithX0(x) + taylorWithX1(x) + taylorWithX2(x) + taylorWithX3(x) + taylorWithX4(x) + Taylor.GetNthTaylorFormulaCoefficient(5) * Math.Pow(x, 5);
            InitializePlotModel(plot6, taylorWithX5);
            this.Controls.Add(this.plot6);
            }

        private void InitializePlotProps(PlotView plot, string funcName, int index)
            {
            int xCoordinate = index * 500 % 1500;
            int yCoordinate = ((int) index / 3) * 400;
            plot.Location = new Point(xCoordinate, yCoordinate);

            plot.Name = funcName;
            plot.PanCursor = Cursors.Hand;
            plot.Size = new Size(484, 312);
            plot.ZoomHorizontalCursor = Cursors.SizeWE;
            plot.ZoomRectangleCursor = Cursors.SizeNWSE;
            plot.ZoomVerticalCursor = Cursors.SizeNS;
            }

        private void InitializePlotModel(PlotView plot, Func<double, double> func)
            {
            var model = new PlotModel { Title = plot.Name };
            model.Series.Add(new FunctionSeries(func, _intervalStart, _intervalEnd, 0.01));
            plot.Model = model;
            }

        #endregion
        }
    }

