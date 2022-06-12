using System.Drawing;
using System.Windows.Forms;

namespace Avionics
{
    class HeadingIndicator : Control
    {
        #region Fields

        // Parameters
        int Heading;

        // Images
        Bitmap bmpBackground = new Bitmap(Avionics.AvionicsResources.HeadingIndicator_Background);
        Bitmap bmpHeadingWheel = new Bitmap(Avionics.AvionicsResources.HeadingWeel);
        Bitmap bmpAircraft = new Bitmap(Avionics.AvionicsResources.HeadingIndicator_Aircraft);

        #endregion

        #region Contructor

        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.Container components = null;

        public HeadingIndicator()
        {
            // Double bufferisation
            SetStyle(ControlStyles.DoubleBuffer | ControlStyles.UserPaint |
                ControlStyles.AllPaintingInWmPaint, true);
        }

        #endregion

        #region Component Designer generated code
        /// <summary>
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
        }
        #endregion

        #region Paint

        protected override void OnPaint(PaintEventArgs pe)
        {
            // Calling the base class OnPaint
            base.OnPaint(pe);

            // Pre Display computings
            Point ptRotation = new Point(150, 150);
            Point ptImgAircraft = new Point(73, 41);
            Point ptImgHeadingWheel = new Point(13, 13);

            bmpBackground.MakeTransparent(Color.Yellow);
            bmpHeadingWheel.MakeTransparent(Color.Yellow);
            bmpAircraft.MakeTransparent(Color.Yellow);

            double alphaHeadingWheel = InterpolPhyToAngle(Heading, 0, 360, 360, 0);

            float scale = (float)this.Width / bmpBackground.Width;

            // display Background
            pe.Graphics.DrawImage(bmpBackground, 0, 0, (float)(bmpBackground.Width * scale), (float)(bmpBackground.Height * scale));

            // display HeadingWheel
            RotateImage(pe, bmpHeadingWheel, alphaHeadingWheel, ptImgHeadingWheel, ptRotation, scale);

            // display Aircraft
            pe.Graphics.DrawImage(bmpAircraft, (int)(ptImgAircraft.X * scale), (int)(ptImgAircraft.Y * scale), (float)(bmpAircraft.Width * scale), (float)(bmpAircraft.Height * scale));

        }

        #endregion

        #region Methods

        /// <summary>
        /// Define the physical value to be displayed on the indicator
        /// </summary>
        /// <param name="aircraftHeading">The aircraft heading in °deg</param>
        public void SetHeadingIndicatorParameters(int aircraftHeading)
        {
            Heading = aircraftHeading;

            this.Refresh();
        }

        #endregion

    }
}