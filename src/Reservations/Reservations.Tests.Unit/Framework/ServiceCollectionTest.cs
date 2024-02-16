using Microsoft.Extensions.DependencyInjection;
using Shouldly;
using Xunit;

namespace Reservations.Tests.Unit.Framework
{
	public class ServiceCollectionTest
	{
		[Fact]
		public void TestTransient()
		{
			//Transient - za każdym razem wywołania klasy/metody będzie tworzona jej instancja
			//Singleton - reużywana za każdym razem będzie używana ta sama instancja
			//Scoped - Pojedyńcza instacja wramach pojedyńczego skopa - czyli obsługa całego żądania http
			var serviceCollection = new ServiceCollection();
			serviceCollection.AddTransient<IMessenger, Messenger>();

			
			var serviceProvider = serviceCollection.BuildServiceProvider();
			//var messenger = serviceProvider.GetService<IMessenger>();
			var messenger = serviceProvider.GetRequiredService<IMessenger>();
			messenger.Send("Test: ");

			var messenger2 = serviceProvider.GetRequiredService<IMessenger>();
			messenger2.Send("Test: ");

			messenger.ShouldNotBeNull();
			messenger2.ShouldNotBeNull();

			messenger.ShouldBe(messenger2);
		}
		[Fact]
		public void TestSingleton()
		{
			var serviceCollection = new ServiceCollection();
			serviceCollection.AddSingleton<IMessenger, Messenger>();


			var serviceProvider = serviceCollection.BuildServiceProvider();
			var messenger = serviceProvider.GetRequiredService<IMessenger>();
			messenger.Send("Test: ");

			var messenger2 = serviceProvider.GetRequiredService<IMessenger>();
			messenger2.Send("Test: ");

			messenger.ShouldNotBeNull();
			messenger2.ShouldNotBeNull();

			messenger.ShouldBe(messenger2);
		}
		[Fact]
		public void TestScoped()
		{
			var serviceCollection = new ServiceCollection();
			serviceCollection.AddScoped<IMessenger, Messenger>();


			var serviceProvider = serviceCollection.BuildServiceProvider();
			using(var scope = serviceProvider.CreateScope())
			{
				var messenger = scope.ServiceProvider.GetRequiredService<IMessenger>();
				messenger.Send("Test: ");

				var messenger2 = scope.ServiceProvider.GetRequiredService<IMessenger>();
				messenger2.Send("Test: ");

				messenger.ShouldNotBeNull();
				messenger2.ShouldNotBeNull();

				messenger.ShouldBe(messenger2);
			}
			
		}

		[Fact]
		public void Test()
		{
			var serviceCollection = new ServiceCollection();
			serviceCollection.AddSingleton<IMessenger, Messenger>();
			serviceCollection.AddTransient<IMessenger, Messenger2>();


			var serviceProvider = serviceCollection.BuildServiceProvider();
			var messengers = serviceProvider.GetServices<IMessenger>();

			var messenger = serviceProvider.GetRequiredService<IMessenger>();
			messenger.Send("Test: ");


			messenger.ShouldNotBeNull();

		}
		private interface IMessenger
		{
			void Send(string message);
		}

		private class Messenger: IMessenger
		{
			private readonly Guid _id =Guid.NewGuid();
			public void Send(string message)
			{
				Console.WriteLine($"{message} .. [{_id}]");
			}
		}
		private class Messenger2 : IMessenger
		{
			private readonly Guid _id = Guid.NewGuid();
			public void Send(string message)
			{
				Console.WriteLine($"{message} .. [{_id}]");
			}
		}
	}
}
