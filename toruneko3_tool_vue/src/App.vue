<script setup>
import { ref, computed } from 'vue'
import itemTypes from './assets/item_types.json'
import unidentifiedItemsCSV from './assets/unidentified_items.json'
import itemsCSV from './assets/items.json'

const selectedType = ref(0)
const selectedUnidentifiedItem = ref(null)
const selectedItem = ref(null)

const unidentifiedItems = ref(unidentifiedItemsCSV)
const items = ref(itemsCSV)
const filteredUnidentifiedItems = computed(() => {
  return unidentifiedItems.value.filter((t) => t.item_type_id === selectedType.value)
})

const filteredItems = computed(() => {
  return items.value
    .filter((t) => t.item_type_id === selectedType.value
      && (!buyingPrice.value || t.buying_price == buyingPrice.value)
      && (!sellingPrice.value || t.selling_price == sellingPrice.value)
      && (Object.keys(indentifiedItems.value.filter((el) => (t.name == el.name))).length == 0)
    )
})

const indentifiedItems = computed(() => {
  return unidentifiedItemsCSV
      .filter((t) => t.item)
      .map(t => { return t.item })
})
const buyingPrice = ref(null)
const sellingPrice = ref(null)

function enter() {
  if (!selectedUnidentifiedItem.value) {
    return
  }

  let un = unidentifiedItemsCSV.find(el => el.name == selectedUnidentifiedItem.value.name)
  if (un) {
    un.item = selectedItem.value
    un.buyingPrice = buyingPrice.value
    un.sellingPrice = sellingPrice.value
  }
}

function changedUnidentifiedItem() {
  selectedItem.value = selectedUnidentifiedItem.value.item
  buyingPrice.value = selectedUnidentifiedItem.value.buyingPrice
  sellingPrice.value = selectedUnidentifiedItem.value.sellingPrice
}
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
    <select v-model="selectedUnidentifiedItem" @change="changedUnidentifiedItem">
      <option v-for="item in filteredUnidentifiedItems" :key="item.name" :value="item">
        {{ item.name }}
      </option>
    </select>
    <br/>
    <br/>
    識別アイテム:
    <select v-model="selectedItem">
      <option v-for="item in filteredItems" :key="item.name" :value="item">
        {{ item.name }}
      </option>
    </select>
    <br/>
    買値:
    <input v-model="buyingPrice" placeholder="買値">
    <br/>
    売値:
    <input v-model="sellingPrice" placeholder="売値">
    
    <br/>
    <button @click="enter">
      決定
    </button>
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
