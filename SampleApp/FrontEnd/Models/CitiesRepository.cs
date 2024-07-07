// Static data repository

public static class CitiesRepository
{
    private static List<string> cities =
        [
            "toronto",
            "Ottawa",
            "montreal",
            "Halifax",
            "Calgary",
        ];

    public static List<string> GetCities() => cities;
}
