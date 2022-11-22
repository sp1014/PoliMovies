<template>
  <div>
    <head>
      <title>Registrar usuario</title>
      <meta charset="utf-8" />
    </head>

<div  class="containerCreated">
 
      <h1>Formulario de registre</h1>
     
      <h3>
        <span>Ya tienes cuenta? <a   v-on:click="login()">Inicia sesion</a></span>
      </h3>
      <input
        type="text"
        v-model="name"
        name="name"
        placeholder="Name"
      />
      <input
        type="text"
        v-model="lastName"
        name="lastname"
        placeholder="Lastname"
      />
      <input
        type="text"
        v-model="email"
        name="email"
        placeholder="Email"
      />
      <input
        type="password"
        v-model="password"
        name="password"
        placeholder="Password"
      />
      <input
        type="text"
        v-model="doc"
        name="doc"
        placeholder="Doc"
      />
      <input
        type="hidden"
        v-model="status"
        name="status"
        placeholder="status"
      />
      <input
	  type="hidden"
        v-model="idRol"
        name="rol"
        placeholder="Rol"
      />


     
      <select   v-model="idTypeDoc" name="idTypeDoc">
  <option v-for="ti in TypeDocUser"  :value="ti.id"  :key="ti.id" >{{ti.nameTypeDoc}}</option>
  
</select>
	 
	  <input v-on:click="save()" type="submit" name="register"> 

	</div>
  </div>
</template>
<style scoped>
 @import "../assets/css/estilo.css"; 
</style>
<script>

import axios from 'axios'
export default {
  name: "createdUser",
  data: function () {
    return {
      name: "",
      lastName: "",
      email: "",
      password: "",
      doc: "",
      status: 1,
      idRol: 1,
      idTypeDoc: 2,
      TypeDocUser:{},
    };
  },
  methods:{
	login(){
		this.$router.push('/login')
	},
	CreatedUser(){
		let User={
			name: this.name,
      lastName:  this.lastName,
      email:  this.email,
      password:  this.password,
      doc:  this.doc,
      status:  this.status,
      idRol:  this.idRol,
      idTypeDoc:  this.idTypeDoc,
		};
		axios.post('https://localhost:44375/api/User',User)
	},
  TypedocU(){
axios.get("https://localhost:44375/api/UserData/Doc").then((response) => {
        if (response.status === 200) {
          this.TypeDocUser = response.data;
        }
      });
  }
  ,
	save(){
		this.CreatedUser()
	}
  },
  created: function () {
    this.TypedocU();
  }
};
</script>