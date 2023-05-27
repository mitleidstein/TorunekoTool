<script setup>
import { ref, computed, onMounted } from "vue";
import itemTypes from "./assets/item_types.json";
import unidentifiedItemsCSV from "./assets/unidentified_items.json";
import itemsCSV from "./assets/items.json";
import monstersCSV from "./assets/monsters.json";
import mainCharacterLevelsCSV from "./assets/main_charactor_levels.json";

const selectedType = ref(0);
const selectedUnidentifiedItem = ref(null);
const selectedItem = ref(null);
const selectedMonster = ref(null);
const selectedMainCharacterLevel = ref(null);

const items = ref(itemsCSV);

const unidentifiedItems = ref([]);
const filteredUnidentifiedItems = computed(() => {
  let unItems = unidentifiedItems.value.filter(
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
  indentifiedItems.value = unidentifiedItems.value
    .filter((t) => t.item && t.item_type_id === selectedType.value)
    .map((t) => {
      return t.item;
    })
    .sort(function (a, b) {
      return a.name > b.name ? 1 : -1;
    });
}

function enter() {
  if (!selectedUnidentifiedItem.value) {
    return;
  }

  let un = unidentifiedItems.value.find(
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

    // VueのlocalStorageで複雑な値を扱う
    // https://v2.ja.vuejs.org/v2/cookbook/client-side-storage
    const parsed = JSON.stringify(unidentifiedItems.value);
    localStorage.setItem("unidentifiedItems", parsed);
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
  selectedUnidentifiedItem.value = null;
  selectedItem.value = null;
  buyingPrice.value = null;
  sellingPrice.value = null;
  savedItem.value = null;
  savedBuyingPrice.value = null;
  savedSellingPrice.value = null;
  updateIndentifiedItems();
}

function reset() {
  var result = window.confirm("データをリセットします。よろしいですか？");
  if (result) {
    localStorage.clear();
    unidentifiedItems.value = unidentifiedItemsCSV;
    changedRadioButton();
    console.log("reset");
  }
}

function damage() {
  //let basicOffense = selectedMainCharacterLevel.value.offense *((8 / 2) + 8) * 0.0625;
  //let basicDeffense = (8155591/8388608)^(selectedMonster.value.defense);
  let basicOffense = selectedMainCharacterLevel.value.offense *((8 / 2) + 8) * 0.0625;
  let basicDeffense = ((35)^(selectedMonster.value.defense)) / ((36)^(selectedMonster.value.defense));
  let basicDamage = basicOffense * basicDeffense;
  // private void DamageEquation()
  let minDamage = Math.round(basicDamage * 7 / 8);
  let maxDamage = Math.round(basicDamage * 9 / 8);
  return `${minDamage}～${maxDamage}`;
}

onMounted(() => {
  let localData = localStorage.getItem("unidentifiedItems");
  if (localData) {
    console.log("load");
    unidentifiedItems.value = JSON.parse(localData);
  } else {
    console.log("new");
    unidentifiedItems.value = unidentifiedItemsCSV;
  }
  updateIndentifiedItems();
});
</script>

<template>
  <div>
    <h3 class="left_title">
      トルネコの大冒険3<br />
      アイテム識別ツール
    </h3>
    <br />
    <div class="left_text_centerplace">
      アイテム種別:
      <select v-model="selectedType" @change="changedRadioButton">
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
      <div v-else><br /></div>

      <br />
      買値:
      <input v-model="buyingPrice" placeholder="買値" />
      <div v-if="savedBuyingPrice">
        保存されている買値: {{ savedBuyingPrice }}
      </div>
      <div v-else><br /></div>

      <br />
      売値:
      <input v-model="sellingPrice" placeholder="売値" />
      <div v-if="savedSellingPrice">
        保存されている売値: {{ savedSellingPrice }}
      </div>
      <div v-else><br /></div>

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
      <br />
      <div class="box">
        <ul>
          <li v-for="item in indentifiedItems" :key="item.name">
            {{ item.name }}
          </li>
        </ul>
      </div>

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

      
      <br />
      モンスター:
      <br />
      <select v-model="selectedMonster" @change="changedRadioButton">
        <option v-for="monster in monstersCSV" :key="monster.name" :value="monster">
          {{ monster.name }}
        </option>
      </select>
      <br />
      <div v-if="selectedMonster!=null">
        {{ selectedMonster.name }}<br />
        HP: {{ selectedMonster.hp }}<br />
        攻撃力: {{ selectedMonster.offense }}<br />
        守備力: {{ selectedMonster.defense }}<br />
        経験値: {{ selectedMonster.experience }}
      </div>

      <br />
      主人公のレベル:
      <br />
      <select v-model="selectedMainCharacterLevel" @change="changedRadioButton">
        <option v-for="mainCharacterLevel in mainCharacterLevelsCSV" :key="mainCharacterLevel.level" :value="mainCharacterLevel">
          {{ mainCharacterLevel.level }}
        </option>
      </select>
      <div v-if="selectedMainCharacterLevel!=null">
        主人公の攻撃力: {{ selectedMainCharacterLevel.offense }}
      </div>

      <div v-if="selectedMonster!=null && selectedMainCharacterLevel!=null">
        与えるダメージ {{ damage() }}
      </div>
      

      <br />
      <br />
      <button @click="reset">データをリセット</button>
      <br />
      <br />

      <a href="https://www.free-counter.jp/"
        ><img
          src="https://www.f-counter.net/j/62/1683802457/"
          alt="アクセスカウンター"
      /></a>
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

.box {
  height: 100px; /* 横幅を200pxに指定 */
  border: 1px solid #000; /* わかりやすくボーダーを引く */
  overflow-y: scroll; /* 縦方向にスクロール可能にする */
}

.left_title {
  text-align: center;
  margin: 0 auto;
}
.left_text_centerplace {
  text-align: left;
  width: 90%;
  margin: 0 auto;
}

@media screen and (min-width: 640px) {
  .left_title {
    text-align: center;
    margin: 0 auto;
  }
  .left_text_centerplace {
    text-align: left;
    width: fit-content;
    margin: 0 auto;
  }
}
</style>
