<?php error_reporting(E_ALL ^ E_NOTICE) ?>

<?php
include_once "../../../controller/packageServiceController/weedingController.php";

$result = getAllWeeding();
// for Table row==========================================================
if (isset($_POST["bookPackage"])) {
    // if (isset($_SESSION["shoppingCart"])) {
    //     $item_array_id = array_column($_SESSION["shoppingCart"], "itemId");
    //     if (!in_array($_POST["hiddenPackageId"], $item_array_id)) {
    //         $count = count($_SESSION["shoppingCart"]) + 1;
    //         $item_array = array(
    //             'itemId' => $_POST["hiddenPackageId"],
    //             'itemName' => $_POST["hiddenPackageName"],
    //             'itemPrice' =>  $_POST["hiddenPrice"],
    //             'itemTransportCost' => $_POST["hiddenTransportCost"],
    //             'itemVendor' =>  $_POST["hiddenVendor"]
    //         );
    //         $_SESSION["shoppingCart"][$count] = $item_array;
    //     } else {
    //         @include_once "../../errors/alreadyAddedPackage.php";
    //     }
    // } else {
    //     $item_array = array(
    //         'itemId' => $_POST["hiddenPackageId"],
    //         'itemName' => $_POST["hiddenPackageName"],
    //         'itemPrice' => $_POST["hiddenPrice"],
    //         'itemTransportCost' => $_POST["hiddenTransportCost"],
    //         'itemVendor' => $_POST["hiddenVendor"]
    //     );
    //     $_SESSION["shoppingCart"][0] = $item_array;
    // }
}
?>


<?php

if ($result->num_rows > 0) {
    while ($row = $result->fetch_assoc()) {
        $rating = $row["rating"] * 20;
        ?>
        <form method="post" action="weeding.php">
            <div class="venues-slide first" style="margin-bottom: 10px;">
                <div class=" text" style="padding-left: 50px">
                    <h3 style="color: #848484; float: left; width: 50%; padding-bottom: 15px; height: auto;">Package type : <?php echo  $row["packageType"] ?></h3>
                    <h3 style="color: #848484; float: left; width: 50%; padding-bottom: 15px; height: auto;">Package Name : <?php echo  $row["packageName"] ?></h3>
                    <div class=reviews><?php echo  $row["rating"] . " " ?>
                        <div class=star>
                            <div class=fill style="width:<?php echo $rating ?>%"></div>
                        </div>reviews
                    </div>
                    <div class=" outher-info" style="padding-top: 15px;">
                        <div class="info-slide first">
                            <?php if ($row["caterersAvailableStatus"] == "Yes") echo "<label>Caterers | </label>";  ?>
                        </div>
                        <div class="info-slide first">
                            <?php if ($row["decorFloristsAvailableStatus"] == "Yes") echo "<label>Decor & Florists | </label>";  ?>
                        </div>
                        <div class="info-slide first">
                            <?php if ($row["makeupAndHairAvailableStatus"] == "Yes") echo "<label>Make-up and Hair | </label>";  ?>
                        </div>
                        <div class="info-slide first">
                            <?php if ($row["weddingCardsAvailableStatus"] == "Yes") echo "<label>Wedding Cards | </label>";  ?>
                        </div>
                        <div class="info-slide first">
                            <?php if ($row["mehandiAvailableStatus"] == "Yes") echo "<label>Mehandi | </label>";  ?>
                        </div>
                        <div class="info-slide first">
                            <?php if ($row["cakesAvailableStatus"] == "Yes") echo "<label>Cakes | </label>";  ?>
                        </div>
                        <div class="info-slide first">
                            <?php if ($row["djAvailableStatus"] == "Yes") echo "<label>DJ | </label>";  ?>
                        </div>
                        <div class="info-slide first">
                            <?php if ($row["photographersAvailableStatus"] == "Yes") echo "<label>Photographers | </label>";  ?>
                        </div>
                        <div class="info-slide first">
                            <?php if ($row[""] == "Yes") echo "<label>Entertainment | </label>";  ?>
                        </div>
                    </div>
                    <div class=" outher-info">
                        <div class="info-slide first">
                            <label>Price</label>
                            <span><?php echo $row["price"] ?></span>
                        </div>
                        <div class="info-slide">
                            <label>Transport cost</label>
                            <span><?php echo  $row["transportCost"] ?><small> (Owners)</small></span>
                        </div>
                        <div class="info-slide">
                            <label>Available</label>
                            <span><?php echo  $row["availableStatus"] ?><small> (status)</small></span>
                        </div>
                    </div>
                    <div class="outher-link">
                        <label>Description</label><br>
                        <span><?php echo  $row["description"] ?><small> (quantity)</small></span>
                    </div>
                    <?php
                        if ($row["availableStatus"] == "yes" || $row["availableStatus"] == "Yes") {
                    ?>
                    <div class="button">
                        <input type="submit" class="btn" name="" value="Book Now" />
                    </div>
                </div>
            </div>

        </form>
    <?php
            }

            ?>
<?php
    }
} else {
    include_once "../../errors/spinner.php";
}
?>