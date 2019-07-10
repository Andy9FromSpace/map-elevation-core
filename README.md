# map-elevation

An elevation service that uses DEM data in the HGT or GeoTIFF format.

This is the ASP.NET Core MVC version, for the ASP.NET Web API 2 version go to https://github.com/Andy9FromSpace/map-elevation

## API

```GET http://elevation.map.santolibre.net/api/v1/elevation?encodedPoints=[encodedPoints]```

### Parameters

<table>
    <tr>
      <th>Parameter</th>
      <th>Description</th>
    </tr>
    <tr>
      <td>encodedPoints</td>
      <td>Points in the encoded polyline format (https://developers.google.com/maps/documentation/utilities/polylinealgorithm)</td>
    </tr>
    <tr>
      <td>smoothingMode</td>
      <td>None (default), WindowSmooth or FeedbackSmooth</td>
    </tr>
</table>

### Response

rangeElevations: array of [distance, elevation]

```
{
  rangeElevations: [[0, 302], [120, 342], [254, 296], [487, 246]]
}
```

```GET https://elevation.map.santolibre.net/api/v1/metadata```

### Examples

Get elevations of a list of points

```GET https://elevation.map.santolibre.net/api/v1/elevation?encodedPoints=ksiuxAe%60nzN_%40qFqBkTiByWeAoLk%40kPsB%7DF%5DcC```

Get elevations of a list of points with smoothing

```GET https://elevation.map.santolibre.net/api/v1/elevation?encodedPoints=ksiuxAe%60nzN_%40qFqBkTiByWeAoLk%40kPsB%7DF%5DcC&&smoothingMode=FeedbackSmooth```

### IIS configuration

If the elevation service is hosted in IIS the max query string size should be increased to allow larger elevation queries.

Either change/add the following setting in the web.config or globally in applicationHost.config

<requestLimits maxQueryString="16384" />
