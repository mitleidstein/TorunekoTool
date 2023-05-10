<script setup>
import { ref, computed } from 'vue'
import itemTypes from './assets/item_types.json'
import unidentifiedItemsCSV from './assets/unidentified_items.json'
import itemsCSV from './assets/items.json'

const selectedType = ref(0)
const unidentifiedItems = ref(unidentifiedItemsCSV)
const items = ref(itemsCSV)
const filteredUnidentifiedItems = computed(() => {
  return unidentifiedItems.value.filter((t) => t.item_type_id === selectedType.value)
})
const filteredItems = computed(() => {
  return items.value
    .filter((t) => t.item_type_id === selectedType.value
      && (!buyingPrice.value || t.buying_price == buyingPrice.value)
      && (!sellingPrice.value || t.selling_price == sellingPrice.value))
})
const buyingPrice = ref(null)
const sellingPrice = ref(null)
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
    <br/>
    <br/>
    アイテム選択肢:
    <select>
      <option v-for="item in filteredItems" :key="item.name" :value="item.id">
        {{ item.name }}
      </option>
    </select>
    <br/>
    買値:
    <input v-model="buyingPrice" placeholder="買値">
    <br/>
    売値:
    <input v-model="sellingPrice" placeholder="売値">
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
