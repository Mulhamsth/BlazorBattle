using BlazorBattles.Shared;
using Blazored.Toast.Services;

namespace BlazorBattles.Client.Services
{
	public class UnitService : IUnitService
	{
		private readonly IToastService toastservice;

		public UnitService(IToastService toastservice) 
		{
			this.toastservice = toastservice;
		}
		public IList<Unit> Units => new List<Unit>
		{
			new Unit {Id = 1, Title = "Knight", Attack = 10, Defence = 10, BananaCost = 100},
			new Unit {Id = 2, Title = "Archer", Attack = 15, Defence = 5, BananaCost = 150},
			new Unit {Id = 3, Title = "Knight", Attack = 20, Defence = 1, BananaCost = 200},
		};
		public IList<UserUnit> MyUnits { get; set; } = new List<UserUnit>();

		public void AddUnit(int unitId)
		{
			var unit = Units.First(u => u.Id == unitId);
			MyUnits.Add(new UserUnit { UnitId = unit.Id, HitPoints = unit.HitPoints});
			toastservice.ShowSuccess($"Your {unit.Title} has been built!");
		}
	}
}
