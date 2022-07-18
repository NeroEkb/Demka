using System.Windows;

namespace Demka
{
    /// <summary>
    /// The View for custom window
    /// </summary>
    public class WindowViewModel : BaseViewModel
    {
        #region Private Member
        /// <summary>
        /// The window this view controls
        /// </summary>
        private Window mWindow;
        /// <summary>
        /// A margin around the window for the shadow
        /// </summary>
        private int mOuterMarginSize = 10;
        /// <summary>
        /// A radius of corners
        /// </summary>
        private int mWindowRadius = 10;


        #endregion

        #region Public Properties

        /// <summary>
        /// The size of resize border of a window
        /// </summary>
        public int ResizeBorder { get; set; } = 6;

        public Thickness ResizeBorderThickness { get { return new Thickness(ResizeBorder + OuterMarginSize); } }
        /// <summary>
        /// A margin around the window for the shadow
        /// </summary>
        public int OuterMarginSize
        {
            get
            {
                return mWindow.WindowState == WindowState.Maximized ? 0 : mOuterMarginSize;
            }
            set
            {
                mOuterMarginSize = value;
            }
        }


        /// <summary>
        /// A margin around the window for the shadow
        /// </summary>
        public Thickness OuterMarginThikness { get { return new Thickness(OuterMarginSize); } }


        /// <summary>
        /// A radius of corners
        /// </summary>
        public int WindowRadius
        {
            get
            {
                return mWindow.WindowState == WindowState.Maximized ? 0 : mWindowRadius;
            }
            set
            {
                mWindowRadius = value;
            }
        }
        /// <summary>
        /// A radius of corners
        /// </summary>
        public CornerRadius WindowCornerRadius { get { return new CornerRadius(WindowRadius); } }
        /// <summary>
        /// The Height of the title of a window
        /// </summary>
        public int TitleHeight { get; set; } = 42;
        public GridLength TitleHeightGridLenght { get { return new GridLength(TitleHeight + ResizeBorder); } }





        #endregion

        #region Constructor

        /// <summary>
        /// Default constructor
        /// </summary>
        public WindowViewModel(Window window)
        {
            mWindow = window;
            //Listen for window resize
            mWindow.StateChanged += (sender, e) =>
            {
                //Fire off events for all properties that are affected by a resize
                OnPropertyChanged(nameof(ResizeBorderThickness));
                OnPropertyChanged(nameof(OuterMarginSize));
                OnPropertyChanged(nameof(OuterMarginThikness));
                OnPropertyChanged(nameof(WindowRadius));
                OnPropertyChanged(nameof(WindowCornerRadius));
            };
                   
        }

        #endregion
    }
}
