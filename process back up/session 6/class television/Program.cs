// File: tv.cs

class Television
{
    private int channel = 0;
    private int volume = 0; // data hiding. dont want user to have access to device. only if he meets the limits.
    private bool isOn = false;

    public bool IsOn() //on method.
    {
        return isOn; //give you status of the TV.
    }
    public void TurnOn()
    {
        isOn = true;
        // do the code to turn the tv on
    }
    public void TurnOff()
    {
        isOn = false; // turn the TV off
        // do the code to turn the tv off
    }

    public int CurrentVolume()
    {
        return volume;
    }
    public void IncreaseVolume() // increase volume based on the following limitation.
    {
        if (volume < 100) // limit. but user does not know the limit.
        {
            volume = volume + 1;
            // do the code to increase the volume
        }
    }
    public void DecreaseVolume()
    {
        if (volume > 0)
        {
            volume = volume - 1;
            // do the code to decrease the volume
        }
    }

    public int CurrentChannel()
    {
        return channel;
    }
    public void ChangeChannel(int Channel) // int channel is what the user enters for which channel they want.
    {
        if (Channel > 0 && Channel < 50)
        {
            channel = Channel;
            // do the code to change the
            // channel on the tv
        }
    }
}

class TestTV
{
    static void Main()
    {
        Television tv = new Television();

        if (tv.IsOn() == false)
        {
            tv.TurnOn();
        }

        tv.ChangeChannel(3);

        tv.IncreaseVolume();
        tv.IncreaseVolume();
        tv.IncreaseVolume();
        tv.IncreaseVolume();

        tv.TurnOff();
    }
}