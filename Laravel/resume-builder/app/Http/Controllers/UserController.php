<?php

namespace App\Http\Controllers;

use App\Models\User;
use Illuminate\Http\Request;

class UserController extends Controller
{
    //
    function register(Request $request)
    {
        $user = new User;
        $user->email = $request->email;
        $user->first_name = $request->first_name;
        $user->middle_name = $request->middle_name;
        $user->last_name = $request->last_name;
        $user->save();
        echo "User registered successfully";
    }
    function login(Request $request)
    {
        $user = User::where('email', $request->email)->first();
        if ($user->email == $request->email)
            return view('resume');
        else
            echo "Invalid user";
    }
}
