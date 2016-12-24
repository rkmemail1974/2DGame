﻿using UnityEngine;
using System.Collections.Generic;
using UnityEngine.SceneManagement;

public static class NavigationManager {

    public struct Route
    {
        public string RouteDescription;
        public bool CanTravel;
    }

    public static Dictionary<string, Route> RouteInformation = new Dictionary<string, Route>() {
        { "Overworld", new Route { RouteDescription = "The Big Bad World", CanTravel = true } },
    { "Construction", new Route { RouteDescription =  "The construction area", CanTravel = false } },
     { "Town", new Route { RouteDescription =  "The main town", CanTravel = true } },
      { "Campsite", new Route { RouteDescription =  "The campsite", CanTravel = false } },
};

    public static string GetRouteInfo(string destination)
    {
        return RouteInformation.ContainsKey(destination) ? RouteInformation[destination].RouteDescription : null;
    }

    public static bool CanNavigate(string destination)
    {
        return RouteInformation.ContainsKey(destination) ? RouteInformation[destination].CanTravel : false;
    }

    public static void NavigateTo(string destination)
    {
        SceneManager.LoadScene(destination);
    }
}
