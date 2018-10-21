
namespace Lands.Infrastructure
{
    using ViewModels;
    
    public class IntanceLocater
    {
        #region Properties
        public MainViewModel Main { get; set; }
        #endregion

        #region Constructor

        public  IntanceLocater()
        {
            this.Main = new MainViewModel();
        }
        #endregion
    }
}
