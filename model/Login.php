<?php
class Login
{
    private $username;
    private $password;

    public function getUsername()
    {
        return $this->username;
    }
    public function setUsername($username)
    {
        $this->username = $username;

        return $this;
    }
    public function getPassword()
    {
        return $this->password;
    }
    public function setPassword($password)
    {
        $this->password = $password;

        return $this;
    }
    public function Login($username, $password)
    {
        $this->username = $username;
        $this->password = $password;
    }
}
