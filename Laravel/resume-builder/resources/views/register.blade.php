<x-layout>
    <x-slot:title>
        Register
        </x-slot>
        <h2>Register yourself</h2>
        <form action="register" method="post">
            @csrf
            <div class="mb-3 mt-3">
                <label for="first_name" class="form-lable">First Name</label>
                <input type="text" name="first_name" id="first_name" class="form-control">
            </div>
            <div class="mb-3 mt-3">
                <label for="middle_name" class="form-lable">Middle Name</label>
                <input type="text" name="middle_name" id="middle_name" class="form-control">
            </div>
            <div class="mb-3 mt-3">
                <label for="last_name" class="form-lable">Last Name</label>
                <input type="text" name="last_name" id="last_name" class="form-control">
            </div>
            <div class="mb-3 mt-3">
                <label for="email" class="form-lable">Email</label>
                <input type="text" name="email" id="email" class="form-control">
            </div>
            <button type="submit" class="btn btn-primary">Submit</button>
            <button type="button" class="btn btn-warning" id="already_registered">Already registered</button>
        </form>
        <br>
        <script>
            const already_registered = document.getElementById("already_registered");
            already_registered.onclick = function() {
                window.location.href = "/login";
            }
        </script>
</x-layout>