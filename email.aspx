<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="email.aspx.cs" Inherits="dr.email" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
  <form id="loginForm" runat="server">
  <div class="form-group">
    <label for="username">Username:</label>
    <input type="text" id="username" name="username" class="form-control" required>
  </div>
  <div class="form-group">
    <label for="password">Password:</label>
    <input type="password" id="password" name="password" class="form-control" required>
  </div>
  <button type="submit" class="btn btn-primary">Login</button>
</form>

</body>
</html>
