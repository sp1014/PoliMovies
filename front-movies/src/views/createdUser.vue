<template>
    <div>
   

<head>
	<title>Registrar usuario</title>
	<meta charset="utf-8">

</head>

    <form method="post">

		<h1>Formulario de registre</h1>
		<h3><span>Ya tienes cuenta? <a href="index.html">Inicia sesion</a></span></h3>
    	<input type="text" name="Idcliente" placeholder="Idcliente">
		<input type="text" name="usuario" placeholder="usuario">
		<input type="password" name="contraseña" placeholder="contraseña.">
		<input type="text" name="nombres" placeholder="nombres">
		<input type="text" name="apellidos" placeholder="apellidos">
		<input type="text" name="telefono" placeholder="telefono">
		<input type="text" name="dirección" placeholder="dirección">
		<input type="email" name="email" placeholder="email">
    	<input type="text" name="edad" placeholder="edad">
        <input type="submit" name="register">
    </form>
        
    </div>
</template>
<style scoped>
@import '../assets/css/estilo.css';
</style>
<script>
export default {
       
}
</script>