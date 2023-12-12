namespace TrafficPolice.Interfaces;

using TrafficPolice.Models;

public interface  IAllFines {
    IEnumerable<FineModel> Fines { get; }
}