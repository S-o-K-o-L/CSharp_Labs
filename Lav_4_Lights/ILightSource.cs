namespace Lav_4_Lights
{
    public interface ILightSource
    {
        string Color { get; set; }
        int Power { get; set; }
        bool TryToLightRoom(int areaSquare);
        string LightingRoom(int areaSquare);
    }
}