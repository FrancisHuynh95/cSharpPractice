using System;
using System.Runtime.InteropServices;

class RemoteControlCar
{
    private int _meters = 0;
    private int _battery = 100;
    public static RemoteControlCar Buy()
    {
        return new RemoteControlCar();
    }

    public string DistanceDisplay()
    {
        int meters = this._meters;
        return $"Driven {meters} meters";
    }

    public string BatteryDisplay()
    {
        int percentage = this._battery;
        if(percentage == 0) return "Battery empty";
        return $"Battery at {percentage}%";
    }

    public void Drive()
    {
        if(this._battery == 0) return;
        this._meters+= 20;
        this._battery--;
    }
}
