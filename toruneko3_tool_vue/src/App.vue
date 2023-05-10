<script setup>
import { ref, computed } from 'vue'
import itemTypes from './assets/item_types.json'
import unidentifiedItemsCSV from './assets/unidentified_items.json'

const selectedType = ref(0)
const unidentifiedItems = ref(unidentifiedItemsCSV)
const filteredUnidentifiedItems = computed(() => {
  return unidentifiedItems.value.filter((t) => t.item_type_id === selectedType.value)
})
</script>

<template>
  <div>
    アイテム種別:
    <select v-model="selectedType">
      <option v-for="type in itemTypes" :key="type.id" :value="type.id">
        {{ type.name }}
      </option>
    </select>
    {{ selectedType }}
    <br/>
    未識別名:
    <select>
      <option v-for="item in filteredUnidentifiedItems" :key="item.name" :value="item.id">
        {{ item.name }}
      </option>
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
