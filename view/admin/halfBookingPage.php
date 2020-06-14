<?php error_reporting(E_ALL ^ E_NOTICE)?>

<?php
session_start();
@require_once "../../model/Login.php";
@require_once "../../model/Person.php";
@include_once "../../controller/PersonController.php";
$username = "";
$name = "";
$email = "";
$phone = "";
$password = "";
$address = "";

// for logout============================================================>
if (isset($_POST['logoutPerson'])) {
    session_destroy();
    @include_once "../errors/success.php";
}

// include "../register.php";
?>


<!DOCTYPE html>
<html lang="en">

<head>
    <meta charset="utf-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0, maximum-scale=1.0, user-scalable=0">
    <title>Admin Panel</title>

    <link rel="../shortcut icon" href="../images/Favicon.ico">
    <link href="../css/bootstrap.css" rel="stylesheet">
    <link href="../css/owl.carousel.css" rel="stylesheet">
    <link href="../css/styles.css" rel="stylesheet" />
    <link href="../css/datepicker.css" rel="stylesheet" />
    <link href="../css/loader.css" rel="stylesheet">
    <link href="../css/docs.css" rel="stylesheet">
    <link href="../css/jquery.selectbox.css" rel="stylesheet" />
    <link href="https://fonts.googleapis.com/css?family=Domine:400,700%7COpen+Sans:300,300i,400,400i,600,600i,700,700i%7CRoboto:400,500" rel="stylesheet">

    <script>
        function searchByName() {
            var input, filter, table, tr, td, i, txtValue;
            input = document.getElementById("nameInput");
            filter = input.value.toUpperCase();
            table = document.getElementById("myTable");
            tr = table.getElementsByTagName("tr");
            for (i = 0; i < tr.length; i++) {
                td = tr[i].getElementsByTagName("td")[0];
                if (td) {
                    txtValue = td.textContent || td.innerText;
                    if (txtValue.toUpperCase().indexOf(filter) > -1) {
                        tr[i].style.display = "";
                    } else {
                        tr[i].style.display = "none";
                    }
                }
            }
        }

        function searchByLocation() {
            var input, filter, table, tr, td, i, txtValue;
            input = document.getElementById("locationInput");
            filter = input.value.toUpperCase();
            table = document.getElementById("myTable");
            tr = table.getElementsByTagName("tr");
            for (i = 0; i < tr.length; i++) {
                td = tr[i].getElementsByTagName("td")[3];
                if (td) {
                    txtValue = td.textContent || td.innerText;
                    if (txtValue.toUpperCase().indexOf(filter) > -1) {
                        tr[i].style.display = "";
                    } else {
                        tr[i].style.display = "none";
                    }
                }
            }
        }

        function searchByDate() {
            var input, filter, table, tr, td, i, txtValue;
            input = document.getElementById("dateInput");
            filter = input.value.toUpperCase();
            table = document.getElementById("myTable");
            tr = table.getElementsByTagName("tr");
            for (i = 0; i < tr.length; i++) {
                td = tr[i].getElementsByTagName("td")[4];
                if (td) {
                    txtValue = td.textContent || td.innerText;
                    if (txtValue.toUpperCase().indexOf(filter) > -1) {
                        tr[i].style.display = "";
                    } else {
                        tr[i].style.display = "none";
                    }
                }
            }
        }
    </script>
</head>

<body class="inner-page">
    <div class="page">
        <header id="header">
            <div class="quck-link">
                <div class="container">
                    <div class="mail"><a href="MailTo:eventorganizer@gmail.com"><span class="icon icon-envelope"></span>eventorganizer@gmail.com</a></div>
                    <div class="right-link">
                        <ul>
                            <li class="sub-links">
                                <a href="../index.php"><span class="icon icon-envelope"></span>Go to Homepage</a>
                            </li>
                            <li class="sub-links">
                                <a href="javascript:;"><?php echo $_SESSION['name'] ?><span class="icon icon-arrow-down"></span></a>
                                <ul class="sub-nav" style="right:-40px">
                                    <?php
                                    if ($_SESSION['name'] != "") {
                                        echo '<li>';
                                        echo '    <a href="javascript:;" data-toggle="modal" data-target="#logoutModal">Logout</a>';
                                        echo '</li>';
                                    }
                                    if ($_SESSION['name'] == "") {
                                        echo '<li>';
                                        echo '    <a href="../index.php">Login</a>';
                                        echo '</li>';
                                    }
                                    ?>
                                </ul>
                            </li>
                        </ul>
                    </div>
                </div>
            </div>
            <nav id="nav-main">
                <div class="container">
                    <div class="navbar navbar-inverse">
                        <div class="navbar-header">
                            <a href="../index.php" class="navbar-brand"><img src="../images/logo.png" alt="" style="max-width: 80px"></a>
                            <button type="button" class="navbar-toggle" data-toggle="collapse" data-target=".navbar-collapse">
                                <span class="icon1-barMenu"></span>
                                <span class="icon1-barMenu"></span>
                                <span class="icon1-barMenu"></span>
                            </button>

                        </div>
                        <div class="navbar-collapse collapse">
                            <ul class="nav navbar-nav">
                                <li class="single-col ">
                                    <a href="dashboard.php">Home </a>
                                </li>
                                <li class="single-col ">
                                    <a href="vendor.php">Vendor </a>
                                </li>
                                <li class="single-col ">
                                    <a href="customer.php">Customer </a>
                                </li>
                                <li class="single-col ">
                                    <a href="pendingBook.php">Pending Book </a>
                                </li>
                                <li class="single-col active">
                                    <a href="">Booking <span class="icon icon-arrow-down"></span></a>
                                    <ul>
                                        <li><a href="halfBookingPage.php">Half Paid</a></li>
                                        <li><a href="fullBookingPage.php">Full Paid</a></li>
                                    </ul>
                                </li>
                                <li class="single-col ">
                                    <a href="adminAccount.php">My Account </span></a>

                                </li>
                            </ul>
                        </div>
                    </div>
                </div>
            </nav>
        </header>

        <!-- logout -->
        <div class="modal modal-vcenter fade" id="logoutModal" role="dialog">
            <div class="modal-dialog login-popup" role="document">
                <div class="modal-content">
                    <div class="close-icon" aria-label="Close" data-dismiss="modal"><img src="../images/close-icon.png" alt=""></div>
                    <div class="left-img"><img src="../images/login-leftImg.png" alt=""></div>
                    <div class="right-info">
                        <h1>Are you sure ? </h1>
                        <form method="POST" action="<?php echo htmlspecialchars($_SERVER['PHP_SELF']); ?>">
                            <div class="input-form">
                                <div class="submit-slide">
                                    <input type="submit" class="btn" value="Yes" name="logoutPerson">
                                </div>
                            </div>
                        </form>
                    </div>
                </div>
            </div>
        </div>

        <div class="searchFilter-main">
            <section class="searchFormTop">
                <div class="container">
                    <div class="searchCenter">
                        <div class="refineCenter">
                            <span class="icon icon-filter"></span>
                            <span>Refine Customer</span>
                        </div>
                        <div class="searchFilter" style="width: 100%;">
                            <div class="input-box" style="width: 33.3%;">
                                <div class="icon icon-grid-view"></div>
                                <input type="text" id="nameInput" onkeyup="searchByName()" placeholder="Search for name" title="Type a name">
                            </div>
                            <div class="input-box searchlocation" style="width: 33.3%;">
                                <div class="icon icon-location-1"></div>
                                <input type="text" id="locationInput" onkeyup="searchByLocation()" placeholder="Search for Location" title="Type a location">
                            </div>
                            <div class="input-box date" style="width: 33.3%;">
                                <div class="icon icon-calander-month"></div>
                                <input type="text" id="dateInput" onkeyup="searchByDate()" placeholder="Search for Date" title="Type a date">
                            </div>
                        </div>
                    </div>
                </div>
            </section>
            <section class="content">
                <div class="container">
                    <div class="venues-view">
                        <div class="row">

                            <!-- <div class="right-side" id="changeOrder">

                                </div> -->
                            <div class="content">
                                <div class="container">
                                    <div class="bookin-info">
                                        <table class="bookin-table" id="myTable">
                                            <tr>
                                                <td class="first Theading">Name</td>
                                                <td class="Theading">Email</td>
                                                <td class="Theading">Phone</td>
                                                <td class="Theading">Address</td>
                                                <td class="Theading last">Registration Date</td>
                                            </tr>
                                            <?php
                                            $result = getAllCustomer();
                                            if ($result->num_rows > 0) {
                                                while ($row = $result->fetch_assoc()) {
                                                    echo "<tr>";
                                                    echo '    <td class="first">';
                                                    echo '        <label>Name</label>';
                                                    echo         "<p>" .  $row["name"] . "</p>";
                                                    echo '    </td>';
                                                    echo '    <td>';
                                                    echo '        <label>Email</label>';
                                                    echo         "<p>" . $row["email"] . "</p>";
                                                    echo '    </td>';
                                                    echo '    <td>';
                                                    echo '        <label>Phone</label>';
                                                    echo         "<p>" . $row["phone"] . "</p>";
                                                    echo '    </td>';
                                                    echo '    <td>';
                                                    echo '        <label>Address</label>';
                                                    echo         "<p>" . $row["address"] . "</p>";
                                                    echo '    </td>';
                                                    echo '    <td class="last">';
                                                    echo '        <label>Registration date</label>';
                                                    echo         "<p>" . $row["registration_date"] . "</p>";
                                                    echo '    </td>';
                                                    echo '</tr> ';
                                                }
                                            }
                                            ?>
                                        </table>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </section>
        </div>




        <footer id="footer">
            <div class="footer-top">
                <div class="container">
                    <div class="row">

                        <div class="col-lg-4 col-sm6 col-md-4 ">
                            <div class="footer-link">
                                <h5>Company</h5>
                                <ul>
                                    <li><a href="../aboutUs.php">About Us</a></li>
                                    <li><a href="../privacy_policy.php">Privacy Policy</a></li>
                                    <li><a href="../career.php">Careers</a></li>
                                    <li><a href="../blog.php">Blogs</a></li>
                                    <li><a href="../contact.php">Contact Us</a></li>
                                </ul>
                            </div>
                        </div>
                        <div class="col-lg-4 col-sm-6 col-md-4">
                            <div class="footer-contact">
                                <h5>Contact us</h5>
                                <div class="contact-slide">
                                    <div class="icon icon-location-1"></div>
                                    <p>Khilkhet, Nikunjo-2, Dhaka, Bangladesh </p>
                                </div>
                                <div class="contact-slide">
                                    <div class="icon icon-phone"></div>
                                    <p>01948510951</p>
                                </div>

                                <div class="contact-slide">
                                    <div class="icon icon-message"></div>
                                    <a href="MailTo:eventorganizer@gmail.com">eventorganizer@gmail.com</a>
                                </div>
                            </div>
                        </div>
                        <div class="col-lg-4 col-sm-8 col-md-4">
                            <div class="contact-form">
                                <h5>Connect with us</h5>
                                <p>Connect with us so that u can get update news and offer. </p>

                                <div class="sosal-midiya">
                                    <ul>
                                        <li><a href="#"><span class="icon icon-facebook"></span></a></li>
                                        <li><a href="#"><span class="icon icon-twitter"></span></a></li>
                                        <li><a href="#"><span class="icon icon-linkedin"></span></a></li>
                                        <li><a href="#"><span class="icon icon-skype"></span></a></li>
                                        <li><a href="#"><span class="icon icon-google-plus"></span></a></li>
                                        <li><a href="#"><span class="icon icon-play"></span></a></li>
                                    </ul>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
            <div class="footer-bottom">
                <div class="container">
                    <p>Copyright &copy; <span></span> - EventOrganizer | All Rights Reserved</p>
                </div>
            </div>
        </footer>
    </div>


    <!-- Bootstrap core JavaScript
        ================================================== -->
    <!-- Placed at the end of the document so the pages load faster -->
    <script type="text/javascript" src="../js/jquery-1.12.4.min.js"></script>
    <script type="text/javascript" src="../js/bootstrap.js"></script>
    <script type="text/javascript" src="../js/jquery.form-validator.min.js"></script>
    <script type="text/javascript" src="../js/jquery.selectbox-0.2.js"></script>
    <script type="text/javascript" src="../js/coustem.js"></script>
    <script type="text/javascript" src="../js/placeholder.js"></script>
</body>

</html>