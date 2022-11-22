<template>
<div>
      <head>
<meta charset="UTF-8">
<meta http-equiv="X-UA-Compatible" content="IE=edge">
<meta name="viewport" content="width=device-width, initial-scale=1.0">
<title>Filmlane - Best movie collections</title>
<link rel="shortcut icon" href="./favicon.svg" type="image/svg+xml">
</head>
<header class="header" data-header>
  <div class="container">

    <div class="overlay" data-overlay></div>

    <a href="./index.html" class="logo">
    <img src="../assets/images/logo.svg" alt="Filmlane logo"> 
    </a>

    <div class="header-actions">

      <button class="search-btn">
        <ion-icon name="search-outline"></ion-icon>
      </button>

      <div class="lang-wrapper">
        <label for="language">
          <ion-icon name="globe-outline"></ion-icon>
        </label>

        <select name="language" id="language">
          <option value="en">EN</option>
          <option value="au">AU</option>
          <option value="ar">AR</option>
          <option value="tu">TU</option>
        </select>
      </div>

      <button class="btn btn-primary"  v-on:click="login()">Sign in</button>

    </div>

    <button class="menu-open-btn" data-menu-open-btn>
      <ion-icon name="reorder-two"></ion-icon>
    </button>

    <nav class="navbar" data-navbar>

      <div class="navbar-top">

        <a href="./index.html" class="logo">
          <img src="../assets/images/logo.svg" alt="Filmlane logo"> 
        </a>

        <button class="menu-close-btn" data-menu-close-btn>
          <ion-icon name="close-outline"></ion-icon>
        </button>

      </div>

      <ul class="navbar-list">

        <li>
          <a href="./index.html" class="navbar-link">Home</a>
        </li>

        <li>
          <a href="#" class="navbar-link">Movie</a>
        </li>

        <li>
          <a href="#" class="navbar-link">Tv Show</a>
        </li>

        <li>
          <a href="#" class="navbar-link">Web Series</a>
        </li>

        <li>
          <a href="#" class="navbar-link">Pricing</a>
        </li>

      </ul>

      <ul class="navbar-social-list">

        <li>
          <a href="#" class="navbar-social-link">
            <ion-icon name="logo-twitter"></ion-icon>
          </a>
        </li>

        <li>
          <a href="#" class="navbar-social-link">
            <ion-icon name="logo-facebook"></ion-icon>
          </a>
        </li>

        <li>
          <a href="#" class="navbar-social-link">
            <ion-icon name="logo-pinterest"></ion-icon>
          </a>
        </li>

        <li>
          <a href="#" class="navbar-social-link">
            <ion-icon name="logo-instagram"></ion-icon>
          </a>
        </li>

        <li>
          <a href="#" class="navbar-social-link">
            <ion-icon name="logo-youtube"></ion-icon>
          </a>
        </li>

      </ul>

    </nav>

  </div>
</header>

<main>
    <article>

      <section class="movie-detail">
        <div class="container">

          <div class="movie-detail-content">
              <center><h1 class="h1 detail-title"><strong>Video </strong>information</h1></center>

              <font  color="white">movie title</font>
              <input  v-model="TitleMovie" name="Name" type="text" class="form-control mr-3" placeholder="Star Wars" required><br>
              <font  color="white">Date Production</font>
              <input  v-model="DateProduction" name="Name" type="date" class="form-control mr-3" placeholder="Star Wars" required><br>
              <font    color="white">Duration</font>
              <input  v-model="Duration" name="Name" type="text" class="form-control mr-3" placeholder="Star Wars" required><br>
              <font   color="white">Actors</font>
              <input  v-model="Actors" name="Name" type="text" class="form-control mr-3" placeholder="Star Wars" required><br>
              <font   color="white">Directors</font>
              <input  v-model="Directors" name="Name" type="text" class="form-control mr-3" placeholder="Star Wars" required><br>
              <font  color="white">Producers</font>
              <input  v-model="Producers" name="Name" type="text" class="form-control mr-3" placeholder="Star Wars" required><br>
              

              <font  color="white">Type:</font>
              <select name="type" class="form-control mr-3" >
               <option selected >N/A</option>
               <option value="1">Action</option>
               <option value="2">Adventure</option>
               <option value="3">Science Fiction</option>
               <option value="4">Comedy</option>
              </select><br><br>

              <!-- <font  color="white">Price:</font><br>
              <input name="price" type="text" class="form-control mr-3" placeholder="$100.000"><br> -->

              <input type="file"  v-on:change="getFile($event)"  id="name"  ><br><br>
              <input v-on:click="save()" type="submit" name="register"> 
             <a> <button type="input"  @click="submitForm($event)" name="button">add video</button></a>
          </div>
        </div>
        <figure class="movie-detail-banner">
            <!-- <img
              src="../assets/images/Img.jpg"
              alt="Free guy movie poster"
            /> -->
          </figure>
      </section>
    </article>
  </main>


<footer class="footer">

<div class="footer-top">
<div class="container">

  <div class="footer-brand-wrapper">

    <a href="./index.html" class="logo">
      <img src="../assets/images/logo.svg" alt="Filmlane logo"> 
    </a>

    <ul class="footer-list">

      <li>
        <a href="./index.html" class="footer-link">Home</a>
      </li>

      <li>
        <a href="#" class="footer-link">Movie</a>
      </li>

      <li>
        <a href="#" class="footer-link">TV Show</a>
      </li>

      <li>
        <a href="#" class="footer-link">Web Series</a>
      </li>

      <li>
        <a href="#" class="footer-link">Pricing</a>
      </li>

    </ul>

  </div>

  <div class="divider"></div>

  <div class="quicklink-wrapper">

    <ul class="quicklink-list">

      <li>
        <a href="#" class="quicklink-link">Faq</a>
      </li>

      <li>
        <a href="#" class="quicklink-link">Help center</a>
      </li>

      <li>
        <a href="#" class="quicklink-link">Terms of use</a>
      </li>

      <li>
        <a href="#" class="quicklink-link">Privacy</a>
      </li>

    </ul>

    <ul class="social-list">

      <li>
        <a href="#" class="social-link">
          <ion-icon name="logo-facebook"></ion-icon>
        </a>
      </li>

      <li>
        <a href="#" class="social-link">
          <ion-icon name="logo-twitter"></ion-icon>
        </a>
      </li>

      <li>
        <a href="#" class="social-link">
          <ion-icon name="logo-pinterest"></ion-icon>
        </a>
      </li>

      <li>
        <a href="#" class="social-link">
          <ion-icon name="logo-linkedin"></ion-icon>
        </a>
      </li>

    </ul>

  </div>

</div>
</div>

<div class="footer-bottom">
<div class="container">

  <p class="copyright">
    &copy; 2022 <a href="#">codewithsadee</a>. All Rights Reserved
  </p>

   <img src="../assets/images/footer-bottom-img.png" alt="Online banking companies logo" class="footer-bottom-img">

</div>
</div>

</footer>
          
          
</div>
</template>

<style>

@import "../assets/css/estilo.css"; 
@import "https://fonts.googleapis.com";
@import "https://fonts.gstatic.com";
@import "https://fonts.googleapis.com/css2?family=Poppins:wght@400;500;600;700&display=swap";

</style>

<script>
const Movies= "http://www.apinetpolix.somee.com/api/Movie";
import axios from "axios";
const video= "https://localhost:44375/api/File/cargar-archivo"
export default {
  name: "movieInfo",
 
  methods: {
    clearFile(){
      this.clearMovies.Name ="",
      this.clearMovies.Archivo=""
    },
    data(){
return{ 
    TitleMovie:"",
    DateProduction:"",
    Duration:"",
    Actors:"",
    Directors:"",
    Producers:"",
    idRental:1,
    IdSale:1,
    IdQuanlification:1,
    ISerie:1,
    IdFile:1,
    IdColections:1,
    file:{
"Name": "",
"Archivo": ""
    },
clearMovies: [],
videos: video,
file: "",
}},
save(){
    let Movie={
        TitleMovie: this.TitleMovie,
    DateProduction:this.DateProduction,
    Duration:this.Duration,
    Actors:this.Actors,
    Directors:this.Directors,
    Producers:this.Producers,
    file:this.file,
    idRental:this. idRental,
    IdSale:this.IdSale,
    IdQuanlification:1,
    ISerie:1,
    IdFile:1,
    IdColections:1,
    }
    axios.post(Movies,Movie)
},
getFile(event) {
    this.file = event.target.files[0];
        console.log(this.file);
        },
        submitForm(event) {
      event.preventDefault();
      let formData = new FormData();
      formData.append("file", this.file)
      let config = {
        headers: {
          "Content-Type": "multipart/form-data",
        },
      };
     
        axios.post(video, formData, config)
        .then(function (response) {
          if (response.status === 200) {
            console.log(response.data);
          }
        });
    }
  },
   
    }
  


</script>