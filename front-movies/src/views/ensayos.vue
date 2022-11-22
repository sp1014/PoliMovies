<template>
    <div>
 
     
    
      <table  class="table table-dark" id="table">
  <thead>
    <tr>
      <th scope="col">Name user</th>
      <th scope="col">HOLAS</th>
  
    </tr>
  </thead>
  <tbody>
    <tr v-for="tu in TypeDocUser" :key="tu.id">
      <th scope="row"></th>
      <td>S {{tu.nameTypeDoc}}</td>
      <td>HOLA</td>
 
    
    </tr>
    
  </tbody>
</table>

<select   name="idTypeDoc">
  <option v-for="ti in TypeDocUser"  :value="ti"  :key="ti.id" >{{ti.nameTypeDoc}}</option>
  
</select>
<!--  
<select v-model="TypeDocUser" class="form-select" id="Translatefrom">
            <option v-for="ti in TypeDocUser" :value="ti" :key="ti.id">
              {{ti.nameTypeDoc}}
            </option>
          </select>  -->
  </div>
</template>

<style></style>

<script>

import axios from 'axios'
export default {
    name: "ensayos",
    data(){
        return{
            TypeDocUser:{},
           
            
        }
    },
    methods: {
    TypedocU(){
axios.get("https://localhost:44375/api/UserData/Doc").then((response) => {
        if (response.status === 200) {
          this.TypeDocUser = response.data;
        }
      });
  },
},
created: function () {
    this.TypedocU();
  }}
    </script>