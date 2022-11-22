<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>{{$title ?? 'Resume Builder'}}</title>
    @vite(['resources/sass/app.scss','resources/js/app.js'])
</head>
<body>
    <div class="container">
<header>
    
    <nav class="navbar navbar-expand-sm bg-primary justify-content-center">
<div class="container">
<a href="#" class="navbar-brand"><h1>Resume Builder</h1></a>
<ul class="navbar-nav">
<li class="nav-item">
<a href="#" class="nav-link">Link 1</a>
</li class="nav-item">
<a href="#" class="nav-link">Link 2</a>
<li>

</li>
</ul>
</div>
    </nav>
</header>
<main>
{{$slot}}
</main>
<footer class="bg-primary text-white text-center">
<p>&copy:2022</p>
</footer>
    </div>
</body>
</html>