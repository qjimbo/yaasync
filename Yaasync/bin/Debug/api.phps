<?php
$action = $_GET['action'];
switch($action)
{
    case "availableactions":
        echo availableactions($_GET['key']);
        break;
    case "syncposition":
        echo syncposition(
                          $_GET['key'],
                          $_GET['galaxy'],
                          $_GET['system'],
                          $_GET['planet'],
                          $_GET['gX'],
                          $_GET['gY'],
                          $_GET['gZ'],
                          $_GET['sX'],
                          $_GET['sY'],
                          $_GET['sZ']
                         );
        break;
    case "syncscreenshot":
        echo syncscreenshot(
                          $_GET['key'],
                          $_GET['screenshotid'],
                          $_GET['galaxy'],
                          $_GET['system'],
                          $_GET['planet'],
                          $_GET['gX'],
                          $_GET['gY'],
                          $_GET['gZ'],
                          $_GET['sX'],
                          $_GET['sY'],
                          $_GET['sZ']
                         );
        break;
}
exit();

function availableactions($key)
{
    return "syncposition,syncscreenshot";
}

function syncposition($key,$galaxy,$system,$planet,$gx,$gy,$gz,$sx,$sy,$sz)
{
    $txt = time() . " SYNC POSITION: Key: " . $key . ". Galaxy: " . $galaxy . ". System: " . $system . ". Planet: " . $planet . ". Galactic XYZ: ".$gX.",".$gY.",".$gZ.". Surface XYZ: ".$sX.",".$sY.",".$sZ;
    file_put_contents('log.txt', $txt.PHP_EOL , FILE_APPEND);
    return "OK";
}

function syncscreenshot($key,$screenshotid,$galaxy,$system,$planet,$gx,$gy,$gz,$sx,$sy,$sz)
{
    $file = null;
    foreach($_FILES as $_file)
    {
	$file = $_file;
    }
    $txt = time() . " SYNC SCREENSHOT: File: " . $file['tmp_name'] . ". Screenshot ID: " . $screenshotid . ". Key: " . $key . ". Galaxy: " . $galaxy . ". System: " . $system . ". Planet: " . $planet . ". Galactic XYZ: ".$gX.",".$gY.",".$gZ.". Surface XYZ: ".$sX.",".$sY.",".$sZ;
    file_put_contents('log.txt', $txt.PHP_EOL , FILE_APPEND);

    return $file['tmp_name'];
}
?>