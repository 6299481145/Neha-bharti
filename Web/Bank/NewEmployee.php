<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
     <title>New Employee</title>
     <link rel="stylesheet" href="Style.css">
</head>
      
      
<body>
    <header>
        <?php
           include 'Header.html';
        ?>
    </header>
    
      
    <form action="NewEmployeeSubmit.php">
        <label for="employee_id">Employee Id</label>
        <input type="text"name="employee_id" id="eid"><br><br>
        <label for="employee_name">Employee Name</label>
        <input type="text"name="employee_name"id="ename"><br><br>
        <label for="branch_code">Branch Code</label>
        <input type="text"name="branch_code"id="bcode"><br><br>

        <!--------for Radio button-------->

        <label for="gender">Gender </label>
        <input type="radio" id="male" name="gender" value="M" checked>
        <label for="male">Male</label>
        <input type="radio"id="female" name="gender"value="F">
        <label for="female">Female</label><br><br>

        <label for="contact_no">Contact_No</label>
        <input type="text" name="contact_no"id="cnum"><br><br>

        <label for="state">State</label>
        <select name="state" id="state">
            <option value="Bihar">Bihar</option>
            <option value="Bangalore">Bangalore</option>

        </select><br><br>

         
        <button>Submit</button>
        <button type="reset">Reset</button>
    </form>
</body>
</html>