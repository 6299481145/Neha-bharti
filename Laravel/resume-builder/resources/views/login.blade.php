<x-layout>
    <x-slot:title>
        Login
        </x-slot>
        <form action="/login" method="post">
            @csrf
            <div class="mb-3 mt-3">
                <label for="email" class="form-lable">Email</label>
                <input type="email" name="email" id="email" class="form-control">
            </div>
            <!-- <div class="mb-3 mt-3">
                <label for="password" class="form-lable">Password</label>
                <input type="password" name="password" id="password" class="form-control">
            </div> -->
            <button type="submit" class="btn btn-primary">Login</button>
        </form>
        <br>
</x-layout>