<?php
session_start();

  // array_push($_SESSION['product_id'], $_POST['p_id']);
  // array_push($_SESSION['product_name'], $_POST['n']);
  // array_push($_SESSION['product_price'], $_POST['p']);
  // array_push($_SESSION["product_transportCost"], $_POST['t']);
  // array_push($_SESSION["product_vendor"], $_POST['v']);

  if (isset($_SESSION["shoppingCart"])) {
    $item_array_id = array_column($_SESSION["shoppingCart"], "itemId");
    if (!in_array($_POST['p_id'], $item_array_id)) {
        $count = count($_SESSION["shoppingCart"]) + 1;
        $item_array = array(
            'itemId' => $_POST['p_id'],
            'itemName' => $_POST['n'],
            'itemPrice' =>  $_POST['p'],
            'itemTransportCost' => $_POST['t'],
            'itemVendor' =>  $_POST['v']
        );
        $_SESSION["shoppingCart"][$count] = $item_array;
    } else {
      echo '<script>confirm("Already added")</script>';
    }
} else {
    $item_array = array(
      'itemId' => $_POST['p_id'],
      'itemName' => $_POST['n'],
      'itemPrice' =>  $_POST['p'],
      'itemTransportCost' => $_POST['t'],
      'itemVendor' =>  $_POST['v']
    );
    $_SESSION["shoppingCart"][0] = $item_array;
}

  echo "Book Now";
?>

