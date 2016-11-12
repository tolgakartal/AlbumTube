using MvvmCross.Core.ViewModels;
using MvvmCross.Platform.IoC;

namespace AlbumTube.Core
{
	public class App : MvxApplication
	{
		public override void Initialize()
		{
			base.Initialize();

			CreatableTypes()
				.EndingWith("Repository")
				.AsInterfaces()
				.RegisterAsLazySingleton();

			CreatableTypes()
				.EndingWith("Services")
				.AsInterfaces()
				.RegisterAsLazySingleton();

			RegisterAppStart(new AppStart());
		}
	}
}