<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="dr.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
        <meta name="viewport" content="width=device-width, initial-scale=1.0" />

    <title></title>
       <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/4.5.2/css/bootstrap.min.css">
    <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.5.1/jquery.min.js"></script>
    <script src="https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.16.0/umd/popper.min.js"></script>
    <script src="https://maxcdn.bootstrapcdn.com/bootstrap/4.5.2/js/bootstrap.min.js"></script>

     <style>
       .container {
    max-width: 400px;
    margin: 0 auto;
    text-align: center;
}

.form-group {
    margin: 10px;
}

.text-danger {
    color: #ff0000;
}
    </style>
</head>
<body>
        <div class="container">
        <h2>Login Form</h2>
            <form id="form1" runat="server">
            <div class="form-group">
                <label for="username">Username:</label>
                <input type="text" class="form-control" id="username" placeholder="Enter username" name="username" required>
            </div>
            <div class="form-group">
                <label for="password">Password:</label>
                <input type="password" class="form-control" id="password" placeholder="Enter password" name="password" required>
            </div>
                <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Button" />
            <button type="submit" class="btn btn-primary">Submit</button>
            </form>
    </div>

</body>
</html>
