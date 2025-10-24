using LastTrain.Persistence;
using System.Collections.Generic;

public interface ITransferDataProvider
{
    List<WeaponUpgradeConfig> WeaponUpgradeConfigs { get; }
    TrainUpgradeConfig TrainUpgradeConfig { get; }
}
