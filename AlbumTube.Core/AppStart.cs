using MvvmCross.Core.ViewModels;

namespace AlbumTube.Core
{
	public class AppStart : MvxNavigatingObject, IMvxAppStart
	{
		public void Start(object hint = null)
		{
			ShowViewModel<MainViewModel>();
		}
	}
}