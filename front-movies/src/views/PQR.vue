
<template>
    <div>
               
    <meta charset="UTF-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Filmlane - Best movie collections</title>

    <link rel="shortcut icon" href="./favicon.svg" type="image/svg+xml">
  
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
                  <center><h1 class="h1 detail-title"><strong>PQR </strong></h1></center>
              
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
    
  <div class="container">
    PQR
    <textarea name="textarea"  v-model="Description" rows="30" cols="200" placeholder="enter your complaints, claims or questions"></textarea>
    <input v-on:click="save()" type="submit" name="register" > 
  </div>

  
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
        
import axios from "axios";
export default {
  name: "PQR",
  methods: {
    data: function(){
return{
Description: "",
date: "2022-11-11",
IdUser: 1
}
    },
methods:{
save(){
     let PQR={
        Description: this.Description,
        date: this.date,
        IdUser: this.IdUser
     };
     axios.post("http://www.apinetpolix.somee.com/api/Pqr",PQR)

    },
}
    }
  
}

</script>