<?php
@include_once "../../model/SinglePackage.php";
@include_once "../../model/BundlePackage.php";

function getSinglePackage()
{
    $connection = mysqli_connect("localhost", "root", "", "event_organizer");
    if (!$connection) {
        return -1;
    }
    $query = "SELECT * from single_package where vendor_username = '" . $_SESSION['username'] . "'";
    $result = $connection->query($query);
    return $result;
    mysqli_close($connection);
}
function getBundlePackage()
{
    $connection = mysqli_connect("localhost", "root", "", "event_organizer");
    if (!$connection) {
        return -1;
    }
    $query = "SELECT * from bundle_package where vendorName = '" . $_SESSION['username'] . "'";
    $result = $connection->query($query);
    return $result;
    mysqli_close($connection);
}
function insertSinglePackage(SinglePackage $singlePackage)
{
    $connection = mysqli_connect("localhost", "root", "", "event_organizer");
    if (!$connection) {
        return -1;
    }
    $findSamePackage = "SELECT package_name, vendor_username from single_package where package_name = '" . $singlePackage->getPackageName() . "' AND vendor_username = '" . $singlePackage->getVendorName() . "'";
    $result = mysqli_query($connection, $findSamePackage);
    while ($row = mysqli_fetch_assoc($result)) {
        $vendorName = $row['vendor_username'];
        $packageName = $row['package_name'];
    }
    if ($vendorName == $singlePackage->getVendorName() && $packageName == $singlePackage->getPackageName()) {
        return -1;
    } else {

        $query = "INSERT into single_package (category, package_name,vendor_username,price, transport_cost, available_status,description, image, rating ) 
    VALUES ('" . $singlePackage->getCategory() . "' , '" . $singlePackage->getPackageName() . "','" . $singlePackage->getVendorName() . "','" . $singlePackage->getPrice() . "','" . $singlePackage->getTransportCost() . "','" . $singlePackage->getAvailableStatus() . "','" . $singlePackage->getDescription() . "','" . "../../packageImage/singlePackagePicture/" . $singlePackage->getImage() . "',0) ";
        if (mysqli_query($connection, $query)) {
            return 1;
        } else {
            return 0;
        }
    }
    mysqli_close($connection);
}

function updateSinglePackage($packageName, $vendorName, $price, $transportCost, $availableStatus, $description)
{
    $connection = new PDO("mysql:host=localhost; dbname=event_organizer", "root", "");
    $connection->setAttribute(PDO::ATTR_ERRMODE, PDO::ERRMODE_EXCEPTION);
    $query = "UPDATE single_package set price = '" . $price . "',transport_cost = '" . $transportCost . "',available_status = '" . $availableStatus . "',description = '" . $description . "'  where  package_name = '" . $packageName . "' AND vendor_username = '" . $vendorName . "'";
    $statement = $connection->prepare($query);
    $result = $statement->execute();
    return $result;
    mysqli_close($connection);
}

function insertBundlePackage(BundlePackage $bundlePackage)
{
    $connection = mysqli_connect("localhost", "root", "", "event_organizer");
    if (!$connection) {
        return -1;
    }
    $findSamePackage = "SELECT packageName, vendorName from bundle_package where packageName = '" . $bundlePackage->getPackageName() . "' AND vendorName = '" . $bundlePackage->getVendorName() . "'";
    $result = mysqli_query($connection, $findSamePackage);
    while ($row = mysqli_fetch_assoc($result)) {
        $vendorName = $row['vendorName'];
        $packageName = $row['packageName'];
    }
    if ($vendorName == $bundlePackage->getVendorName() && $packageName == $bundlePackage->getPackageName()) {
        return -1;
    } else {
        $query = "INSERT into bundle_package (packageType, packageName, caterersAvailableStatus,decorFloristsAvailableStatus,makeupAndHairAvailableStatus, 
        weddingCardsAvailableStatus, mehandiAvailableStatus,cakesAvailableStatus, djAvailableStatus, photographersAvailableStatus,entertainmentAvailableStatus, 
        price, transportCost, description, availableStatus, vendorName, rating) 
        VALUES ('" . $bundlePackage->getPackageType() . "' ,
        '" . $bundlePackage->getPackageName() . "',
        '" . $bundlePackage->getCaterersAvailableStatus() . "',
        '" . $bundlePackage->getDecorFloristsAvailableStatus() . "',
        '" . $bundlePackage->getMakeupAndHairAvailableStatus() . "',
        '" . $bundlePackage->getWeddingCardsAvailableStatus() . "',
        '" . $bundlePackage->getMehandiAvailableStatus() . "',
        '" . $bundlePackage->getCakesAvailableStatus() . "',
        '" . $bundlePackage->getDjAvailableStatus() . "',
        '" . $bundlePackage->getPhotographersAvailableStatus() . "',
        '" . $bundlePackage->getEntertainmentAvailableStatus() . "',
        '" . $bundlePackage->getPrice() . "',
        '" . $bundlePackage->getTransportCost() . "',
        '" . $bundlePackage->getDescription() . "',
        '" . $bundlePackage->getAvailableStatus() . "',
        '" . $bundlePackage->getVendorName() . "',
        0) ";
        if (mysqli_query($connection, $query)) {
            return 1;
        } else {
            return 0;
        }
    }
    mysqli_close($connection);
}

function updateBundlePackage(
    $packageName,
    $vendorName,
    $caterersAvailableStatus,
    $decorFloristsAvailableStatus,
    $makeupAndHairAvailableStatus,
    $weddingCardsAvailableStatus,
    $mehandiAvailableStatus,
    $cakesAvailableStatus,
    $djAvailableStatus,
    $photographersAvailableStatus,
    $entertainmentAvailableStatus,
    $price,
    $transportCost,
    $availableStatus,
    $description
) {
    $connection = new PDO("mysql:host=localhost; dbname=event_organizer", "root", "");
    $connection->setAttribute(PDO::ATTR_ERRMODE, PDO::ERRMODE_EXCEPTION);

    $query = "UPDATE bundle_package set 
            caterersAvailableStatus= '" . $caterersAvailableStatus . "',
            decorFloristsAvailableStatus= '" . $decorFloristsAvailableStatus . "',
            makeupAndHairAvailableStatus= '" . $makeupAndHairAvailableStatus . "', 
            weddingCardsAvailableStatus= '" . $weddingCardsAvailableStatus . "', 
            mehandiAvailableStatus= '" . $mehandiAvailableStatus . "',
            cakesAvailableStatus= '" . $cakesAvailableStatus . "', 
            djAvailableStatus= '" . $djAvailableStatus . "', 
            photographersAvailableStatus= '" . $photographersAvailableStatus . "',
            entertainmentAvailableStatus= '" . $entertainmentAvailableStatus . "',
            price = '" . $price . "',
            transportCost = '" . $transportCost . "',
            availableStatus = '" . $availableStatus . "',
            description = '" . $description . "'  
            where  packageName = '" . $packageName . "' AND vendorName = '" . $vendorName . "'";

    $statement = $connection->prepare($query);
    $result = $statement->execute();
    return $result;
    mysqli_close($connection);
}



