﻿namespace BlazorBattles.Client.Services
{
	public class BananaService : IBananaService
	{
		public int Bananas { get; set; } = 1000;

		public event Action OnChange;

		public void EatBananas(int amount)
		{
			Bananas -= amount;
			BananasChanged();
		}

		void BananasChanged() => OnChange?.Invoke();
	}
}
