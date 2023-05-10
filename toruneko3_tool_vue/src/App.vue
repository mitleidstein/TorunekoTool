<script setup>
// import { ref } from 'vue'
import itemTypes from './assets/item_types.json'
</script>

<template>
  <div>
    <select>
      <option v-for="type in itemTypes" :key="type.id">{{ type.name }}</option>
    </select>
  </div>
</template>

<style>
#app {
  font-family: Avenir, Helvetica, Arial, sans-serif;
  -webkit-font-smoothing: antialiased;
  -moz-osx-font-smoothing: grayscale;
  text-align: center;
  color: #2c3e50;
  margin-top: 60px;
}
</style>
