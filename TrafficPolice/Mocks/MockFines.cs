namespace TrafficPolice.Mocks;

using TrafficPolice.Interfaces;
using TrafficPolice.Models;

public class MockFines : IAllFines {
    public IEnumerable<FineModel> Fines {
        get { 
            return new List<FineModel> {
                new FineModel {Name = "Fine 1", Description = "Some Description for fine", Price = 280, isPaid = false, category = Category.Speed},
                new FineModel {Name = "Fine 2", Description = "Some Description for fine 2", Price = 120, isPaid = true, category = Category.Parking}
            };
        }
    }
}