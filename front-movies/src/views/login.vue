<template>
    <div>
        
 <head>
    <meta charset="UTF-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Document</title>
</head>
    
           <font  color="white">Usuario:</font>  <input name="username" type="text" class="form-control mr-3" placeholder="Username">
           <font  color="white">Contraseña:</font> <input name="password" type="password" class="form-control mr-3" placeholder="Password">
      
      <button type="submit"  class="btn btn-primary">Iniciar Sesión</button>
      <a  v-on:click="formUser()" class="btn btn-primary">  Registrarse</a>
              <div class="qty">'</div>
            
						
 </div>
</template>
<style lang="">
    
</style>
<script>
export default {
    name: 'login',
    methods:{
        formUser() {
this.$router.push("/createdUser");
        }
    }
}
</script>
