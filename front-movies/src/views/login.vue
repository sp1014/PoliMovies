<template>
    <div>
        
 <head>
    <meta charset="UTF-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Document</title>
</head>
    
           <font  color="white">Usuario:</font>  <input name="gmail" v-model="email"  type="text" class="form-control mr-3" placeholder="Username">
           <font  color="white">Contraseña:</font> <input name="password" v-model="password" type="password" class="form-control mr-3" placeholder="Password">
      
      <button type="submit"  class="btn btn-primary">Iniciar Sesión</button>
      <a  v-on:click="formUser()" class="btn btn-primary">  Registrarse</a>
              <div class="qty">'</div>
            
						
 </div>
</template>
<style lang="">
</style>
<script>
// import axios from 'axios';

export default {
    name: 'login',
    data:function() {
      return{
        email: "",
        password: ""
      }  
    },
    methods:{
         formUser() {
 this.$router.push("/createdUser");
         },
         login(){
             let log = {
                 "email" : this.email,
                 "password" : this.password
             };
             axios.post('https://localhost:44375/api/User/',log)
          
         }
    }
}
</script>
