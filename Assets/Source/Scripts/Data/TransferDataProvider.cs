using LastTrain.Data;
using LastTrain.Persistence;
using System.Collections.Generic;

public class TransferDataProvider : ITransferDataProvider
{
    public List<WeaponUpgradeConfig> WeaponUpgradeConfigs => TransferData.Instance.WeaponConfigs;

    public TrainUpgradeConfig TrainUpgradeConfig => TransferData.Instance.TrainUpgradeConfig;
}
