using System;

class RemoteControlCar
{
    public int _speed;
    public int _batteryDrain;
    public int _battery = 100;
    public int _distance = 0;
    // TODO: define the constructor for the 'RemoteControlCar' class

    public RemoteControlCar(int speed, int batteryDrain){
        _speed = speed;
        _batteryDrain = batteryDrain;
    }

    public bool BatteryDrained()
    {
        return this._battery < this._batteryDrain;
    }

    public int DistanceDriven()
    {
        return this._distance;
    }

    public void Drive()
    {
        if(BatteryDrained()) return;
        this._distance += this._speed;
        this._battery -= this._batteryDrain;
    }

    public static RemoteControlCar Nitro()
    {
        return new RemoteControlCar(50, 4);
    }
}

class RaceTrack
{
    // TODO: define the constructor for the 'RaceTrack' class
    private int __distance;

    public RaceTrack(int distance){
        __distance = distance;
    }

    public bool TryFinishTrack(RemoteControlCar car)
    {
       float ratio = __distance / (float)car._speed;
       float batteryUsed = ratio * car._batteryDrain;

       return batteryUsed <= car._battery;
    }
}
