<script setup>
import { ref, computed, onMounted } from "vue";
import itemTypes from "./assets/item_types.json";
import unidentifiedItemsCSV from "./assets/unidentified_items.json";
import itemsCSV from "./assets/items.json";

const selectedType = ref(0);
const selectedUnidentifiedItem = ref(null);
const selectedItem = ref(null);

const items = ref(itemsCSV);
const filteredUnidentifiedItems = computed(() => {
  let unItems = unidentifiedItemsCSV.filter(
    (t) => t.item_type_id === selectedType.value
  );
  if (unindentifiedItemSetting.value == 2) {
    unItems = unItems.filter((t) => !t.item);
  } else if (unindentifiedItemSetting.value == 3) {
    unItems = unItems.filter((t) => t.item);
  }

  return unItems.sort(function (a, b) {
    return a.name > b.name ? 1 : -1;
  });
});

const filteredItems = computed(() => {
  return items.value
    .filter(
      (t) =>
        t.item_type_id === selectedType.value &&
        (!buyingPrice.value || t.buying_price == buyingPrice.value) &&
        (!sellingPrice.value || t.selling_price == sellingPrice.value) &&
        Object.keys(indentifiedItems.value.filter((el) => t.name == el.name))
          .length == 0
    )
    .sort(function (a, b) {
      return a.name > b.name ? 1 : -1;
    });
});

const indentifiedItems = ref([]);
const buyingPrice = ref(null);
const sellingPrice = ref(null);

const savedItem = ref(null);
const savedBuyingPrice = ref(null);
const savedSellingPrice = ref(null);

const unindentifiedItemSetting = ref(1);

function updateIndentifiedItems() {
  indentifiedItems.value = unidentifiedItemsCSV
    .filter((t) => t.item)
    .map((t) => {
      return t.item;
    })
    .sort();
}

function enter() {
  if (!selectedUnidentifiedItem.value) {
    return;
  }

  let un = unidentifiedItemsCSV.find(
    (el) => el.name == selectedUnidentifiedItem.value.name
  );
  if (un) {
    un.item = selectedItem.value;
    un.buyingPrice = buyingPrice.value;
    un.sellingPrice = sellingPrice.value;
    savedItem.value = selectedItem.value;
    savedBuyingPrice.value = buyingPrice.value;
    savedSellingPrice.value = sellingPrice.value;
    selectedUnidentifiedItem.value = un;
    updateIndentifiedItems();
  }
}

function changedUnidentifiedItem() {
  if (!selectedUnidentifiedItem.value) {
    return;
  }
  selectedItem.value = selectedUnidentifiedItem.value.item;
  buyingPrice.value = selectedUnidentifiedItem.value.buyingPrice;
  sellingPrice.value = selectedUnidentifiedItem.value.sellingPrice;
  savedItem.value = selectedUnidentifiedItem.value.item;
  savedBuyingPrice.value = selectedUnidentifiedItem.value.buyingPrice;
  savedSellingPrice.value = selectedUnidentifiedItem.value.sellingPrice;
  updateIndentifiedItems();
}

function changedRadioButton() {
  selectedItem.value = null;
  buyingPrice.value = null;
  sellingPrice.value = null;
  savedItem.value = null;
  savedBuyingPrice.value = null;
  savedSellingPrice.value = null;
  updateIndentifiedItems();
}

onMounted(() => {
  updateIndentifiedItems();
});
</script>

<template>
  <div>
    <h3>
      トルネコの大冒険3<br />
      アイテム識別ツール
    </h3>
    <div class="left_text_centerplace">
      アイテム種別:
      <select v-model="selectedType">
        <option v-for="type in itemTypes" :key="type.id" :value="type.id">
          {{ type.name }}
        </option>
      </select>

      <br />
      <br />
      未識別名:
      <select
        v-model="selectedUnidentifiedItem"
        @change="changedUnidentifiedItem"
      >
        <option :value="null" />
        <option
          v-for="item in filteredUnidentifiedItems"
          :key="item.name"
          :value="item"
        >
          {{ item.name }}
        </option>
      </select>
      <br />
      <br />
      識別アイテム:
      <select v-model="selectedItem">
        <option :value="null" />
        <option v-for="item in filteredItems" :key="item.name" :value="item">
          {{ item.name }}
        </option>
      </select>
      <div v-if="savedItem">保存されているアイテム: {{ savedItem.name }}</div>

      <br />
      <br />
      買値:
      <input v-model="buyingPrice" placeholder="買値" />
      <div v-if="savedBuyingPrice">
        保存されている買値: {{ savedBuyingPrice }}
      </div>

      <br />
      <br />
      売値:
      <input v-model="sellingPrice" placeholder="売値" />
      <div v-if="savedSellingPrice">
        保存されている売値: {{ savedSellingPrice }}
      </div>

      <br />
      <br />
      <button @click="enter">
        <div v-if="savedItem || savedBuyingPrice || savedSellingPrice">
          変更
        </div>
        <div v-else>決定</div>
      </button>

      <br />
      <br />
      <br />
      識別済みアイテム:
      <select>
        <option v-for="item in indentifiedItems" :key="item.name" :value="item">
          {{ item.name }}
        </option>
      </select>

      <br />
      <br />
      <br />
      <div>
        未識別名のリストの表示設定:
        <br />
        <input
          type="radio"
          id="option1"
          value="1"
          v-model="unindentifiedItemSetting"
          @change="changedRadioButton"
        />
        <label for="option1">すべて表示</label>
        <br />
        <input
          type="radio"
          id="option2"
          value="2"
          v-model="unindentifiedItemSetting"
          @change="changedRadioButton"
        />
        <label for="option2">識別されていないものを表示</label>
        <br />
        <input
          type="radio"
          id="option3"
          value="3"
          v-model="unindentifiedItemSetting"
          @change="changedRadioButton"
        />
        <label for="option3">識別されたものを表示</label>
        <br />
      </div>
    </div>
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

.left_text_centerplace {
  text-align: left;
  width: 90%;
  margin: 0 auto;
}
</style>
