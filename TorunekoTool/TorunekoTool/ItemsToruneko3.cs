﻿using System;
using System.Collections.Generic;

namespace TorunekoTool
{
    public class ItemsToruneko3
    {
        public List<DtoItem> GetItemList(int typeNumber)
        {
            switch (typeNumber)
            {
                case 0:
                    return GetItemListRing();

                case 1:
                    return GetItemListKusa();

                case 2:
                    return GetItemListMaki();

                case 3:
                    return GetItemListTsue();

                case 4:
                    return GetItemListTsubo();

                default:
                    throw new Exception("タイプの指定エラー");
            }
        }

        public List<UnidentifiedItem> GetUnidentifiedItemList(int typeNumber)
        {
            var unidentifiedItems = new List<UnidentifiedItem>();

            switch (typeNumber)
            {
                case 0:
                    unidentifiedItems.Add(new UnidentifiedItem("トルコ石の指輪", 0));
                    unidentifiedItems.Add(new UnidentifiedItem("ラピスラズリの指輪", 0));
                    unidentifiedItems.Add(new UnidentifiedItem("モーガナイトの指輪", 0));
                    unidentifiedItems.Add(new UnidentifiedItem("マンダリンの指輪", 0));
                    unidentifiedItems.Add(new UnidentifiedItem("ウルフェナイトの指輪", 0));
                    unidentifiedItems.Add(new UnidentifiedItem("エンスタタイトの指輪", 0));
                    unidentifiedItems.Add(new UnidentifiedItem("クリソコーラの指輪", 0));
                    unidentifiedItems.Add(new UnidentifiedItem("アマゾナイトの指輪", 0));
                    unidentifiedItems.Add(new UnidentifiedItem("ダイオプサイトの指輪", 0));
                    unidentifiedItems.Add(new UnidentifiedItem("トルマリンの指輪", 0));
                    unidentifiedItems.Add(new UnidentifiedItem("アルマンダインの指輪", 0));
                    unidentifiedItems.Add(new UnidentifiedItem("インカローズの指輪", 0));
                    unidentifiedItems.Add(new UnidentifiedItem("スピネルの指輪", 0));
                    unidentifiedItems.Add(new UnidentifiedItem("パールの指輪", 0));
                    unidentifiedItems.Add(new UnidentifiedItem("クリソベリルの指輪", 0));
                    unidentifiedItems.Add(new UnidentifiedItem("サファイアの指輪", 0));
                    unidentifiedItems.Add(new UnidentifiedItem("アンダルサイトの指輪", 0));
                    unidentifiedItems.Add(new UnidentifiedItem("フローライトの指輪", 0));
                    unidentifiedItems.Add(new UnidentifiedItem("ジルコンの指輪", 0));
                    unidentifiedItems.Add(new UnidentifiedItem("スポジュミンの指輪", 0));
                    unidentifiedItems.Add(new UnidentifiedItem("カイアナイトの指輪", 0));
                    unidentifiedItems.Add(new UnidentifiedItem("アゲートの指輪", 0));
                    unidentifiedItems.Add(new UnidentifiedItem("アメジストの指輪", 0));
                    unidentifiedItems.Add(new UnidentifiedItem("ラブラドライトの指輪", 0));
                    unidentifiedItems.Add(new UnidentifiedItem("アクアマリンの指輪", 0));
                    unidentifiedItems.Add(new UnidentifiedItem("オパールの指輪", 0));
                    unidentifiedItems.Add(new UnidentifiedItem("シトリンの指輪", 0));
                    unidentifiedItems.Add(new UnidentifiedItem("マラカイトの指輪", 0));
                    unidentifiedItems.Add(new UnidentifiedItem("モアソナイトの指輪", 0));
                    unidentifiedItems.Add(new UnidentifiedItem("ムーンストーンの指輪", 0));
                    unidentifiedItems.Add(new UnidentifiedItem("ネフライトの指輪", 0));
                    unidentifiedItems.Add(new UnidentifiedItem("パイロープの指輪", 0));
                    unidentifiedItems.Add(new UnidentifiedItem("ペリドットの指輪", 0));
                    unidentifiedItems.Add(new UnidentifiedItem("プラスチックの指輪", 0));
                    unidentifiedItems.Add(new UnidentifiedItem("ローズクォーツの指輪", 0));
                    unidentifiedItems.Add(new UnidentifiedItem("オブシディアンの指輪", 0));
                    unidentifiedItems.Add(new UnidentifiedItem("タンザナイトの指輪", 0));
                    unidentifiedItems.Add(new UnidentifiedItem("ヘマタイトの指輪", 0));
                    unidentifiedItems.Add(new UnidentifiedItem("サーペンティンの指輪", 0));
                    unidentifiedItems.Add(new UnidentifiedItem("カルサイトの指輪", 0));
                    unidentifiedItems.Add(new UnidentifiedItem("メノウの指輪", 0));
                    unidentifiedItems.Add(new UnidentifiedItem("リューサイトの指輪", 0));
                    unidentifiedItems.Add(new UnidentifiedItem("サニディーンの指輪", 0));
                    unidentifiedItems.Add(new UnidentifiedItem("ジェイドの指輪", 0));
                    unidentifiedItems.Add(new UnidentifiedItem("ロードナイトの指輪", 0));
                    unidentifiedItems.Add(new UnidentifiedItem("アズライトの指輪", 0));
                    unidentifiedItems.Add(new UnidentifiedItem("アパタイトの指輪", 0));
                    unidentifiedItems.Add(new UnidentifiedItem("アキシナイトの指輪", 0));
                    unidentifiedItems.Add(new UnidentifiedItem("アンバーの指輪", 0));
                    unidentifiedItems.Add(new UnidentifiedItem("エメラルドの指輪", 0));
                    unidentifiedItems.Add(new UnidentifiedItem("オニキスの指輪", 0));
                    unidentifiedItems.Add(new UnidentifiedItem("ガラスの指輪", 0));
                    unidentifiedItems.Add(new UnidentifiedItem("コーネルピンの指輪", 0));
                    unidentifiedItems.Add(new UnidentifiedItem("サンゴの指輪", 0));
                    unidentifiedItems.Add(new UnidentifiedItem("スフィーンの指輪", 0));
                    unidentifiedItems.Add(new UnidentifiedItem("ダイヤモンドの指輪", 0));
                    unidentifiedItems.Add(new UnidentifiedItem("デマントイドの指輪", 0));
                    unidentifiedItems.Add(new UnidentifiedItem("トパーズの指輪", 0));
                    unidentifiedItems.Add(new UnidentifiedItem("ヘソナイトの指輪", 0));
                    unidentifiedItems.Add(new UnidentifiedItem("ルビーの指輪", 0));
                    break;

                case 1:
                    unidentifiedItems.Add(new UnidentifiedItem("ばら色の草", 1));
                    unidentifiedItems.Add(new UnidentifiedItem("たまむし色の草", 1));
                    unidentifiedItems.Add(new UnidentifiedItem("こがね色の草", 1));
                    unidentifiedItems.Add(new UnidentifiedItem("レモン色の草", 1));
                    unidentifiedItems.Add(new UnidentifiedItem("ピンク色の草", 1));
                    unidentifiedItems.Add(new UnidentifiedItem("ぐんじょう色の草", 1));
                    unidentifiedItems.Add(new UnidentifiedItem("しろい草", 1));
                    unidentifiedItems.Add(new UnidentifiedItem("むらさき色の草", 1));
                    unidentifiedItems.Add(new UnidentifiedItem("つち色の草", 1));
                    unidentifiedItems.Add(new UnidentifiedItem("そら色の草", 1));
                    unidentifiedItems.Add(new UnidentifiedItem("やまぶき色の草", 1));
                    unidentifiedItems.Add(new UnidentifiedItem("こげちゃ色の草", 1));
                    unidentifiedItems.Add(new UnidentifiedItem("きみどり色の草", 1));
                    unidentifiedItems.Add(new UnidentifiedItem("うすむらさき色の草", 1));
                    unidentifiedItems.Add(new UnidentifiedItem("かっ色の草", 1));
                    unidentifiedItems.Add(new UnidentifiedItem("あおい草", 1));
                    unidentifiedItems.Add(new UnidentifiedItem("きいろい草", 1));
                    unidentifiedItems.Add(new UnidentifiedItem("オレンジ色の草", 1));
                    unidentifiedItems.Add(new UnidentifiedItem("おうど色の草", 1));
                    unidentifiedItems.Add(new UnidentifiedItem("みず色の草", 1));
                    unidentifiedItems.Add(new UnidentifiedItem("クリーム色の草", 1));
                    unidentifiedItems.Add(new UnidentifiedItem("こん色の草", 1));
                    unidentifiedItems.Add(new UnidentifiedItem("にじ色の草", 1));
                    unidentifiedItems.Add(new UnidentifiedItem("うすみどり色の草", 1));
                    unidentifiedItems.Add(new UnidentifiedItem("しんくの草", 1));
                    unidentifiedItems.Add(new UnidentifiedItem("はだ色の草", 1));
                    unidentifiedItems.Add(new UnidentifiedItem("こうはくの草", 1));
                    unidentifiedItems.Add(new UnidentifiedItem("あかい草", 1));
                    unidentifiedItems.Add(new UnidentifiedItem("ベージュ色の草", 1));
                    unidentifiedItems.Add(new UnidentifiedItem("みどりの草", 1));
                    unidentifiedItems.Add(new UnidentifiedItem("ちゃ色の草", 1));
                    unidentifiedItems.Add(new UnidentifiedItem("べに色の草", 1));
                    unidentifiedItems.Add(new UnidentifiedItem("はい色の草", 1));
                    break;

                case 2:
                    unidentifiedItems.Add(new UnidentifiedItem("ヒツジの巻物", 2));
                    unidentifiedItems.Add(new UnidentifiedItem("ネズミの巻物", 2));
                    unidentifiedItems.Add(new UnidentifiedItem("ウシの巻物", 2));
                    unidentifiedItems.Add(new UnidentifiedItem("ウズラの巻物", 2));
                    unidentifiedItems.Add(new UnidentifiedItem("モモの巻物", 2));
                    unidentifiedItems.Add(new UnidentifiedItem("ハトの巻物", 2));
                    unidentifiedItems.Add(new UnidentifiedItem("クマの巻物", 2));
                    unidentifiedItems.Add(new UnidentifiedItem("クジラの巻物", 2));
                    unidentifiedItems.Add(new UnidentifiedItem("カメの巻物", 2));
                    unidentifiedItems.Add(new UnidentifiedItem("キツネの巻物", 2));
                    unidentifiedItems.Add(new UnidentifiedItem("ラッコの巻物", 2));
                    unidentifiedItems.Add(new UnidentifiedItem("シカの巻物", 2));
                    unidentifiedItems.Add(new UnidentifiedItem("ブタの巻物", 2));
                    unidentifiedItems.Add(new UnidentifiedItem("トカゲの巻物", 2));
                    unidentifiedItems.Add(new UnidentifiedItem("ヒョウの巻物", 2));
                    unidentifiedItems.Add(new UnidentifiedItem("カラスの巻物", 2));
                    unidentifiedItems.Add(new UnidentifiedItem("ムササビの巻物", 2));
                    unidentifiedItems.Add(new UnidentifiedItem("シャチの巻物", 2));
                    unidentifiedItems.Add(new UnidentifiedItem("ツバメの巻物", 2));
                    unidentifiedItems.Add(new UnidentifiedItem("オオカミの巻物", 2));
                    unidentifiedItems.Add(new UnidentifiedItem("イタチの巻物", 2));
                    unidentifiedItems.Add(new UnidentifiedItem("ペンギンの巻物", 2));
                    unidentifiedItems.Add(new UnidentifiedItem("サルの巻物", 2));
                    unidentifiedItems.Add(new UnidentifiedItem("コアラの巻物", 2));
                    unidentifiedItems.Add(new UnidentifiedItem("ライオンの巻物", 2));
                    unidentifiedItems.Add(new UnidentifiedItem("イヌの巻物", 2));
                    unidentifiedItems.Add(new UnidentifiedItem("コウモリの巻物", 2));
                    unidentifiedItems.Add(new UnidentifiedItem("ヤギの巻物", 2));
                    unidentifiedItems.Add(new UnidentifiedItem("アシカの巻物", 2));
                    unidentifiedItems.Add(new UnidentifiedItem("フクロウの巻物", 2));
                    unidentifiedItems.Add(new UnidentifiedItem("ロバの巻物", 2));
                    unidentifiedItems.Add(new UnidentifiedItem("ネコの巻物", 2));
                    unidentifiedItems.Add(new UnidentifiedItem("カワウソの巻物", 2));
                    unidentifiedItems.Add(new UnidentifiedItem("リスの巻物", 2));
                    unidentifiedItems.Add(new UnidentifiedItem("ウサギの巻物", 2));
                    unidentifiedItems.Add(new UnidentifiedItem("サメの巻物", 2));
                    unidentifiedItems.Add(new UnidentifiedItem("キリンの巻物", 2));
                    unidentifiedItems.Add(new UnidentifiedItem("イルカの巻物", 2));
                    unidentifiedItems.Add(new UnidentifiedItem("カモメの巻物", 2));
                    unidentifiedItems.Add(new UnidentifiedItem("パンダの巻物", 2));
                    unidentifiedItems.Add(new UnidentifiedItem("カッパの巻物", 2));
                    unidentifiedItems.Add(new UnidentifiedItem("カバの巻物", 2));
                    unidentifiedItems.Add(new UnidentifiedItem("サイの巻物", 2));
                    unidentifiedItems.Add(new UnidentifiedItem("ダチョウの巻物", 2));
                    unidentifiedItems.Add(new UnidentifiedItem("トンビの巻物", 2));
                    unidentifiedItems.Add(new UnidentifiedItem("ニワトリの巻物", 2));
                    unidentifiedItems.Add(new UnidentifiedItem("ラクダの巻物", 2));
                    unidentifiedItems.Add(new UnidentifiedItem("ドールの巻物", 2));
                    unidentifiedItems.Add(new UnidentifiedItem("モグラの巻物", 2));
                    unidentifiedItems.Add(new UnidentifiedItem("ゴリラの巻物", 2));
                    unidentifiedItems.Add(new UnidentifiedItem("スズメの巻物", 2));
                    unidentifiedItems.Add(new UnidentifiedItem("タカの巻物", 2));
                    unidentifiedItems.Add(new UnidentifiedItem("ウマの巻物", 2));
                    unidentifiedItems.Add(new UnidentifiedItem("ワシの巻物", 2));
                    unidentifiedItems.Add(new UnidentifiedItem("キジの巻物", 2));
                    unidentifiedItems.Add(new UnidentifiedItem("トドの巻物", 2));
                    unidentifiedItems.Add(new UnidentifiedItem("バクの巻物", 2));
                    unidentifiedItems.Add(new UnidentifiedItem("ヘビの巻物", 2));
                    unidentifiedItems.Add(new UnidentifiedItem("ゾウの巻物", 2));
                    unidentifiedItems.Add(new UnidentifiedItem("タヌキの巻物", 2));
                    unidentifiedItems.Add(new UnidentifiedItem("トラの巻物", 2));
                    break;

                case 3:
                    unidentifiedItems.Add(new UnidentifiedItem("銅の杖", 3));
                    unidentifiedItems.Add(new UnidentifiedItem("チタンの杖", 3));
                    unidentifiedItems.Add(new UnidentifiedItem("ポプラの杖", 3));
                    unidentifiedItems.Add(new UnidentifiedItem("ミズメの杖", 3));
                    unidentifiedItems.Add(new UnidentifiedItem("カメの杖", 3));
                    unidentifiedItems.Add(new UnidentifiedItem("レーガンの杖", 3));
                    unidentifiedItems.Add(new UnidentifiedItem("ラワンの杖", 3));
                    unidentifiedItems.Add(new UnidentifiedItem("カバの杖", 3));
                    unidentifiedItems.Add(new UnidentifiedItem("ターミナリアの杖", 3));
                    unidentifiedItems.Add(new UnidentifiedItem("ナマリの杖", 3));
                    unidentifiedItems.Add(new UnidentifiedItem("モモの杖", 3));
                    unidentifiedItems.Add(new UnidentifiedItem("モミジの杖", 3));
                    unidentifiedItems.Add(new UnidentifiedItem("マツの杖", 3));
                    unidentifiedItems.Add(new UnidentifiedItem("エルムの杖", 3));
                    unidentifiedItems.Add(new UnidentifiedItem("ラミンの杖", 3));
                    unidentifiedItems.Add(new UnidentifiedItem("ヒノキの杖", 3));
                    unidentifiedItems.Add(new UnidentifiedItem("石の杖", 3));
                    unidentifiedItems.Add(new UnidentifiedItem("ヤナギの杖", 3));
                    unidentifiedItems.Add(new UnidentifiedItem("オークの杖", 3));
                    unidentifiedItems.Add(new UnidentifiedItem("サクラの杖", 3));
                    unidentifiedItems.Add(new UnidentifiedItem("シオジの杖", 3));
                    unidentifiedItems.Add(new UnidentifiedItem("ブナの杖", 3));
                    unidentifiedItems.Add(new UnidentifiedItem("クリの杖", 3));
                    unidentifiedItems.Add(new UnidentifiedItem("白金の杖", 3));
                    unidentifiedItems.Add(new UnidentifiedItem("ヤチダモの杖", 3));
                    unidentifiedItems.Add(new UnidentifiedItem("鉄の杖", 3));
                    unidentifiedItems.Add(new UnidentifiedItem("ツバキの杖", 3));
                    unidentifiedItems.Add(new UnidentifiedItem("チークの杖", 3));
                    unidentifiedItems.Add(new UnidentifiedItem("スイショウの杖", 3));
                    unidentifiedItems.Add(new UnidentifiedItem("カツラの杖", 3));
                    unidentifiedItems.Add(new UnidentifiedItem("スギの杖", 3));
                    unidentifiedItems.Add(new UnidentifiedItem("ガラスの杖", 3));
                    unidentifiedItems.Add(new UnidentifiedItem("ペルポックの杖", 3));
                    unidentifiedItems.Add(new UnidentifiedItem("鋼の杖", 3));
                    unidentifiedItems.Add(new UnidentifiedItem("キリの杖", 3));
                    unidentifiedItems.Add(new UnidentifiedItem("ゴムの杖", 3));
                    unidentifiedItems.Add(new UnidentifiedItem("スミの杖", 3));
                    unidentifiedItems.Add(new UnidentifiedItem("ナシの杖", 3));
                    unidentifiedItems.Add(new UnidentifiedItem("カリンの杖", 3));
                    unidentifiedItems.Add(new UnidentifiedItem("メープルの杖", 3));
                    unidentifiedItems.Add(new UnidentifiedItem("イチョウの杖", 3));
                    unidentifiedItems.Add(new UnidentifiedItem("クワの杖", 3));
                    unidentifiedItems.Add(new UnidentifiedItem("アルミの杖", 3));
                    unidentifiedItems.Add(new UnidentifiedItem("アオダモの杖", 3));
                    unidentifiedItems.Add(new UnidentifiedItem("金の杖", 3));
                    unidentifiedItems.Add(new UnidentifiedItem("カシの杖", 3));
                    unidentifiedItems.Add(new UnidentifiedItem("ヤシの杖", 3));
                    unidentifiedItems.Add(new UnidentifiedItem("アルダーの杖", 3));
                    unidentifiedItems.Add(new UnidentifiedItem("ウメの杖", 3));
                    unidentifiedItems.Add(new UnidentifiedItem("カエデの杖", 3));
                    unidentifiedItems.Add(new UnidentifiedItem("カキの杖", 3));
                    unidentifiedItems.Add(new UnidentifiedItem("ナナカマドの杖", 3));
                    unidentifiedItems.Add(new UnidentifiedItem("銀の杖", 3));
                    break;

                case 4:
                    unidentifiedItems.Add(new UnidentifiedItem("あやしい壷", 4));
                    unidentifiedItems.Add(new UnidentifiedItem("かたい壷", 4));
                    unidentifiedItems.Add(new UnidentifiedItem("とがった壷", 4));
                    unidentifiedItems.Add(new UnidentifiedItem("ながい壷", 4));
                    unidentifiedItems.Add(new UnidentifiedItem("たかそうな壷", 4));
                    unidentifiedItems.Add(new UnidentifiedItem("くびれた壷", 4));
                    unidentifiedItems.Add(new UnidentifiedItem("かたむいた壷", 4));
                    unidentifiedItems.Add(new UnidentifiedItem("みかづき形の壷", 4));
                    unidentifiedItems.Add(new UnidentifiedItem("ほそい壷", 4));
                    unidentifiedItems.Add(new UnidentifiedItem("くねった壷", 4));
                    unidentifiedItems.Add(new UnidentifiedItem("だい形の壷", 4));
                    unidentifiedItems.Add(new UnidentifiedItem("はんげつ形の壷", 4));
                    unidentifiedItems.Add(new UnidentifiedItem("ひょうたん形の壷", 4));
                    unidentifiedItems.Add(new UnidentifiedItem("まるい壷", 4));
                    unidentifiedItems.Add(new UnidentifiedItem("すぼまった壷", 4));
                    unidentifiedItems.Add(new UnidentifiedItem("ごつごつした壷", 4));
                    unidentifiedItems.Add(new UnidentifiedItem("ゆがんだ壷", 4));
                    unidentifiedItems.Add(new UnidentifiedItem("ひし形の壷", 4));
                    unidentifiedItems.Add(new UnidentifiedItem("ほし形の壷", 4));
                    unidentifiedItems.Add(new UnidentifiedItem("ふかい壷", 4));
                    unidentifiedItems.Add(new UnidentifiedItem("さんかくの壷", 4));
                    unidentifiedItems.Add(new UnidentifiedItem("だるま形の壷", 4));
                    unidentifiedItems.Add(new UnidentifiedItem("あさい壷", 4));
                    unidentifiedItems.Add(new UnidentifiedItem("たまご形の壷", 4));
                    unidentifiedItems.Add(new UnidentifiedItem("でこぼこな壷", 4));
                    unidentifiedItems.Add(new UnidentifiedItem("だえん形の壷", 4));
                    unidentifiedItems.Add(new UnidentifiedItem("ふるめかしい壷", 4));
                    unidentifiedItems.Add(new UnidentifiedItem("キュートな壺", 4));
                    unidentifiedItems.Add(new UnidentifiedItem("しかくの壺", 4));
                    break;
            }

            return unidentifiedItems;
        }

        public List<DtoType> GetTypeList()
        {
            var typeList = new List<DtoType>();
            typeList.Add(new DtoType(0, "指輪", 242, 216, 187));
            typeList.Add(new DtoType(1, "草", 168, 239, 175));
            typeList.Add(new DtoType(2, "巻物", 231, 225, 143));
            typeList.Add(new DtoType(3, "杖", 156, 167, 226));
            typeList.Add(new DtoType(4, "壷", 255, 239, 133));
            return typeList;
        }

        private List<DtoItem> GetItemListRing()
        {
            var itemList = new List<DtoItem>();

            itemList.Add(new DtoItem("傷みよけの指輪", 0, 5000, 2500, "錆の罠やくさった死体系モンスターの特技を食らっても修正値が下がらない"));
            itemList.Add(new DtoItem("遠投の指輪", 0, 7500, 3000, "投げたアイテム、矢、ブーメラン、大砲の弾、"));
            itemList.Add(new DtoItem("会心の指輪", 0, 15000, 7500, "会心の一撃の出る確率が上昇する"));
            itemList.Add(new DtoItem("回復の指輪", 0, 10000, 5000, "HPの自然回復量が毎ターンに10になるが、満腹度の減る速度が16倍になる"));
            itemList.Add(new DtoItem("きれいな指輪", 0, 8000, 3000, "変化の壷限定"));
            itemList.Add(new DtoItem("混乱よけの指輪", 0, 3000, 1500, "混乱状態にならなくなる"));
            itemList.Add(new DtoItem("ザメハの指輪", 0, 10000, 5000, "部屋に入室すると眠っている敵が必ず目を覚ます"));
            itemList.Add(new DtoItem("しあわせの指輪", 0, 4000, 2000, "受けたダメージに応じて経験値が入る"));
            itemList.Add(new DtoItem("たれ流しの指輪", 0, 4000, 2000, "5~12ターンごとに持っているアイテムを1つ落とす"));
            itemList.Add(new DtoItem("ちからの指輪", 0, 5000, 2500, "ちからと最大値が+3"));
            itemList.Add(new DtoItem("通過の指輪", 0, 5000, 2500, "水中に入ることができるようになる 水中内では水系以外からは攻撃を受けない（GBA版では無効）"));
            itemList.Add(new DtoItem("痛恨の指輪", 0, 15000, 7500, "敵の通常攻撃がときどき痛恨の一撃になる"));
            itemList.Add(new DtoItem("毒けしの指輪", 0, 5000, 2500, "毒攻撃、毒胞子、毒の矢、くさったパン、くさりきったパン、踊りによる力の低下を防ぐ"));
            itemList.Add(new DtoItem("ドラゴンの指輪", 0, 10000, 5000, "炎の息によるダメージを軽減する"));
            itemList.Add(new DtoItem("投げ名人の指輪", 0, 10000, 5000, "割れなくなった壷以外の投げたアイテム、飛び道具が必ず命中する"));
            itemList.Add(new DtoItem("人形よけの指輪", 0, 10000, 5000, "人形系モンスターの特技を防ぐ"));
            itemList.Add(new DtoItem("眠らずの指輪", 0, 5000, 2500, "眠り状態にならなくなる"));
            itemList.Add(new DtoItem("呪いよけの指輪", 0, 5000, 2500, "シャーマンの呪いの特技を防ぐ"));
            itemList.Add(new DtoItem("爆発の指輪", 0, 5000, 2500, "装備したキャラクターを中心に小爆発が起きる"));
            itemList.Add(new DtoItem("ハラペコの指輪", 0, 10000, 5000, "満腹度の減る速度が4倍になる"));
            itemList.Add(new DtoItem("ハラ守りの指輪", 0, 5000, 2500, "踊りによる満腹度の減少を防ぐ"));
            itemList.Add(new DtoItem("ハラモチの指輪", 0, 5000, 2500, "満腹度の減る速度が半分になる"));
            itemList.Add(new DtoItem("ふしぎ投げの指輪", 0, 5000, 2500, "アイテムを投げる時、飛び道具を使った時、"));
            itemList.Add(new DtoItem("へた投げの指輪", 0, 5000, 2500, "投げたアイテム、飛び道具が必ず外れる"));
            itemList.Add(new DtoItem("まがりの指輪", 0, 5000, 2500, "投げたアイテムや、銀の矢をのぞく矢類、ブーメランが"));
            itemList.Add(new DtoItem("見切りの指輪", 0, 25000, 12500, "攻撃をかわしやすくなる(8%→35%)"));
            itemList.Add(new DtoItem("ミニデーモンの指輪", 0, 5000, 2500, "持っているアイテム、Gを盗まれなくなる"));
            itemList.Add(new DtoItem("ルーラの指輪", 0, 7500, 1500, "装備していると5~19行動ごとにワープする"));
            itemList.Add(new DtoItem("ワナあての指輪", 0, 5000, 2500, "投げたアイテム、大砲の弾以外の飛び道具が"));

            return itemList;
        }

        private List<DtoItem> GetItemListKusa()
        {
            var itemList = new List<DtoItem>();
            itemList.Add(new DtoItem("胃拡張のたね", 1, 600, 300, "最大満腹度が10増える"));
            itemList.Add(new DtoItem("胃下垂のたね", 1, 100, 50, "胃下垂状態(200行動の間、満腹度と最大満腹度が上昇しない)になる"));
            itemList.Add(new DtoItem("胃縮小のたね", 1, 600, 300, "最大満腹度が5下がる"));
            itemList.Add(new DtoItem("命の草", 1, 4000, 2000, "最大HPが2増える"));
            itemList.Add(new DtoItem("弟切草", 1, 5000, 2500, "HPを50回復する"));
            itemList.Add(new DtoItem("踊り草", 1, 100, 50, "6行動分踊り状態になる"));
            itemList.Add(new DtoItem("火炎草", 1, 100, 50, "飲むと正面の敵に50ダメージを与える"));
            itemList.Add(new DtoItem("かなしばりのたね", 1, 100, 50, "対象をかなしばり状態にする"));
            itemList.Add(new DtoItem("雑草", 1, 100, 50, "何も起きない"));
            itemList.Add(new DtoItem("しあわせのたね", 1, 5000, 2500, "レベルが1上昇する"));
            itemList.Add(new DtoItem("しんぴの草", 1, 1000, 500, "4行動の間よくきき状態(飲んだ草の効果が上昇する)になる"));
            itemList.Add(new DtoItem("すばやさのたね", 1, 350, 170, "行動速度が1ランク上昇する"));
            itemList.Add(new DtoItem("世界樹の葉", 1, 1500, 750, "壷に入れずに持っているとHPが0になった時に自動で復活する"));
            itemList.Add(new DtoItem("ちからのたね", 1, 5000, 2500, "ちからが1回復する"));
            itemList.Add(new DtoItem("でたらめ草", 1, 100, 50, "でたらめ状態(トルネコ、ポポロは40行動分の間アイテムの状態が全て???になる)になる"));
            itemList.Add(new DtoItem("鉄化のたね", 1, 200, 100, "14行動分鉄化状態になる"));
            itemList.Add(new DtoItem("毒消し草", 1, 300, 1, "ちからが最大値まで回復する"));
            itemList.Add(new DtoItem("毒草", 1, 150, 75, "ちからが1下がる"));
            itemList.Add(new DtoItem("バーサーカーの種", 1, 150, 75, "50行動分バーサーカー状態になる"));
            itemList.Add(new DtoItem("ふこうのたね", 1, 300, 150, "レベルが1下がる"));
            itemList.Add(new DtoItem("まどわし草", 1, 150, 75, "トルネコ、ポポロ、仲間モンスターは10行動分まどわし状態になる"));
            itemList.Add(new DtoItem("めぐすり草", 1, 300, 150, "めぐすり状態(ワナと透明なモンスターが見えるよう)になる"));
            itemList.Add(new DtoItem("目覚まし草", 1, 100, 50, "100行動分目覚まし状態(眠り状態、バクスイ状態にならない)になる"));
            itemList.Add(new DtoItem("メダパニ草", 1, 200, 100, "4~7行動分混乱状態になる"));
            itemList.Add(new DtoItem("めつぶし草", 1, 200, 100, "トルネコ、ポポロ、仲間モンスターは10~13行動分"));
            itemList.Add(new DtoItem("薬草", 1, 2000, 1000, "HPを25回復する"));
            itemList.Add(new DtoItem("ラリホー草", 1, 200, 100, "トルネコ、ポポロは4~5行動分"));
            itemList.Add(new DtoItem("ルーラ草", 1, 100, 50, "ワープする"));

            return itemList;
        }

        private List<DtoItem> GetItemListMaki()
        {
            var itemList = new List<DtoItem>();
            itemList.Add(new DtoItem("イオの巻物", 2, 1000, 500, "視界内の敵全てに30ダメージを与える"));
            itemList.Add(new DtoItem("インパスの巻物", 2, 500, 250, "選択したアイテムを識別する"));
            itemList.Add(new DtoItem("うしろむきの巻物", 2, 500, 250, "周囲8マスの敵を12行動分うしろむき状態にする"));
            itemList.Add(new DtoItem("炎上の巻物", 2, 400, 200, "周囲8マスに10ターンの間火柱を立てる"));
            itemList.Add(new DtoItem("黄金の紙切れ", 2, 20000, 1000, "視界内の全ての敵に150ダメージを与える"));
            itemList.Add(new DtoItem("大風の巻物", 2, 650, 300, "風が吹いてフロアに残り200ターンしか滞在できなくなる"));
            itemList.Add(new DtoItem("大部屋の巻物", 2, 300, 150, "フロア内の掘れる壁を全て破壊して1つの部屋にする"));
            itemList.Add(new DtoItem("かなしばりの巻物", 2, 650, 300, "周囲8マスの敵をかなしばり状態にする"));
            itemList.Add(new DtoItem("銀のたてごとの巻物", 2, 650, 300, "周囲8マスにその階でフロアモンスターとして出現する敵を発生させる"));
            itemList.Add(new DtoItem("くちなしの巻物", 2, 1000, 500, "トルネコが封印状態なる"));
            itemList.Add(new DtoItem("ザオラルの巻物", 2, 650, 300, "地面に置くと床に貼りつき、部屋内に貼りついている時にその部屋内で誰かが力尽きると約50%の確率で復活する"));
            itemList.Add(new DtoItem("時限爆弾の巻物", 2, 1000, 500, "地面に置くと床に貼りつき、攻撃や話かけようとして○ボタンを押すと巻物を中心に小爆発を起こす"));
            itemList.Add(new DtoItem("地獄耳の巻物", 2, 650, 300, "トルネコが地獄耳状態になり、フロア内の敵の位置がマップに表示されるようになる"));
            itemList.Add(new DtoItem("シャナクの巻物", 2, 3000, 500, "所持している壷に入っていないアイテム全ての呪いを解除する"));
            itemList.Add(new DtoItem("スカラの巻物", 2, 1500, 750, "装備している盾の修正値が+1される"));
            itemList.Add(new DtoItem("すてみの巻物", 2, 650, 300, "トルネコを中心に小爆発が起きる"));
            itemList.Add(new DtoItem("砂柱の巻物", 2, 400, 200, "周囲8マスに10ターンの間砂柱を立てる"));
            itemList.Add(new DtoItem("聖域の巻物", 2, 2500, 1250, "上に乗ると敵モンスターが攻撃及び隣接しないと使用できない特技をしてこなくなる"));
            itemList.Add(new DtoItem("聖城の巻物", 2, 400, 200, "地面に置くと床に貼りつき、部屋内に貼りつくと1ターンごとにその部屋内に落ちている貼りついていないアイテムと部屋の壁の中に埋まっているアイテムが1マス移動する"));
            itemList.Add(new DtoItem("千里眼の巻物", 2, 650, 300, "トルネコが千里眼状態になり、フロア内のアイテムの位置がマップに表示されるようになる"));
            itemList.Add(new DtoItem("チキンの巻物", 2, 20000, 1, "トルネコが8行動の間へっぴりごし状態になり、攻撃の命中率が低下する"));
            itemList.Add(new DtoItem("中部屋の巻物", 2, 700, 350, "トルネコを中心とした13×13マスの正方形ないにある掘れる壁を破壊する"));
            itemList.Add(new DtoItem("壷強化の巻物", 2, 700, 350, "壷を1つ割れない状態にし、同時に識別する"));
            itemList.Add(new DtoItem("トラマナの巻物", 2, 650, 300, "トルネコがトラマナ状態になり、トゲトゲ床を踏んでもダメージを受けなくなる"));
            itemList.Add(new DtoItem("ニフラムの巻物", 2, 20000, 1, "敵モンスターに投げ当てるとフロア内の同モンスターが消滅し、そのモンスターが条件を満たすまで出現しなくなる"));
            itemList.Add(new DtoItem("バイキルトの巻物", 2, 1500, 750, "装備している武器の修正値が+1される"));
            itemList.Add(new DtoItem("白紙の巻物", 2, 5000, 2500, "リストコマンド内にある巻物の名前を書き込むことでその巻物として使用することができる"));
            itemList.Add(new DtoItem("バクスイの巻物", 2, 650, 300, "視界内の全て敵を10行動分バクスイ状態にし、目覚めた敵は行動速度が1段階アップする"));
            itemList.Add(new DtoItem("はりつけの巻物", 2, 650, 300, "視界内の全ての敵を20行動分はりつけ状態にし、移動不可能にする"));
            itemList.Add(new DtoItem("パワーアップの巻物", 2, 650, 300, "トルネコが30行動の間パワーアップ状態になり、攻撃力が2倍になる"));
            itemList.Add(new DtoItem("パンの巻物", 2, 650, 300, "選択したアイテムをパンに変える"));
            itemList.Add(new DtoItem("ひきよせの巻物", 2, 650, 300, "フロア内に落ちているアイテムをトルネコを中心とした5×5マスの正方形内に最大25個までひきよせる"));
            itemList.Add(new DtoItem("氷結の巻物", 2, 400, 200, "周囲8マスに10ターンの間氷柱を立てる"));
            itemList.Add(new DtoItem("拾えずの巻物", 2, 2500, 1250, "トルネコが拾えず状態になり、落ちているアイテムを拾ったり使ったりすることができなくなる"));
            itemList.Add(new DtoItem("ふはつの巻物", 2, 2000, 1000, "フロア内であらゆる爆発が起きなくなる"));
            itemList.Add(new DtoItem("ベホマラーの巻物", 2, 2500, 1250, "フロア内の全て敵のHPを50回復させる"));
            itemList.Add(new DtoItem("変身の巻物", 2, 1000, 500, "トルネコを40行動分選択した敵モンスターに変身させる"));
            itemList.Add(new DtoItem("巻物のきれはし", 2, 1500, 700, "読んでも何も起きない"));
            itemList.Add(new DtoItem("まものいそぎの巻物", 2, 5000, 2500, "フロア内の全ての敵の行動速度が1ランク上昇する"));
            itemList.Add(new DtoItem("まものしばりの巻物", 2, 650, 300, "視界内の全ての敵を14行動分かなしばり状態にする"));
            itemList.Add(new DtoItem("水がれの巻物", 2, 400, 200, "フロア内の水路の水を全て消滅させる"));
            itemList.Add(new DtoItem("メダパニの巻物", 2, 650, 300, "視界内の全ての敵を4~7行動分混乱状態にする"));
            itemList.Add(new DtoItem("メッキの巻物", 2, 650, 300, "選択した剣や盾にさびの印を付ける"));
            itemList.Add(new DtoItem("モンスターの巻物", 2, 1000, 500, "部屋内で読むとそのフロアがモンスターハウスとなって周囲8マスと部屋内に敵が出現する"));
            itemList.Add(new DtoItem("リレミトの巻物", 2, 100, 50, "ダンジョンから脱出する"));
            itemList.Add(new DtoItem("ルカナンの巻物", 2, 650, 300, "フロア内の全ての敵の防御力を1ランク下げる"));
            itemList.Add(new DtoItem("レミーラの巻物", 2, 650, 300, "レミーラ状態になり、マップが全て埋まり敵の位置が表示され、フロアが明るくなる"));
            itemList.Add(new DtoItem("ワナけしの巻物", 2, 500, 250, "フロア内の罠を全て消滅させる"));
            itemList.Add(new DtoItem("ワナ作動の巻物", 2, 400, 200, "視界内の全ての罠を10ターンの間トルネコの行動直後ごとに作動させる"));
            itemList.Add(new DtoItem("ワナの巻物", 2, 1000, 500, "トルネコの周囲20×20マスの範囲の部屋内にその階で出現する可能性のある罠をランダムで作成する"));
            return itemList;
        }

        private List<DtoItem> GetItemListTsue()
        {
            var itemList = new List<DtoItem>();
            itemList.Add(new DtoItem("いかずちの杖", 3, 800, 400, "25ダメージを与える"));
            itemList.Add(new DtoItem("イカリの杖", 3, 1200, 600, "イカリ状態になり与えるダメージが2倍になる"));
            itemList.Add(new DtoItem("痛みわけの杖", 3, 1200, 600, "痛みわけ状態になり、対象は使用キャラがダメージを受けた時に、同ダメージを受けるようになる"));
            itemList.Add(new DtoItem("一時しのぎの杖", 3, 1000, 500, "階段上にかなしばり状態でワープさせる"));
            itemList.Add(new DtoItem("大損の杖", 3, 2000, 1000, "使用キャラのHPの半分を対象に与える"));
            itemList.Add(new DtoItem("おびえの杖", 3, 2000, 1000, "12~19行動分おびえ状態になり、行動速度が一ランク上昇する"));
            itemList.Add(new DtoItem("風の杖", 3, 800, 400, "正面3マスに10ターン風柱を立てる"));
            itemList.Add(new DtoItem("かなしばりの杖", 3, 1200, 600, "かなしばり状態にする"));
            itemList.Add(new DtoItem("きとうしの杖", 3, 3000, 1500, "いかずちの杖、場所替えの杖、メダパニの杖のどれか1つの効果が発動する"));
            itemList.Add(new DtoItem("クオーターの杖", 3, 2000, 1000, "HPを4分の1にする"));
            itemList.Add(new DtoItem("げんじゅつしの杖", 3, 8000, 4000, "どこかにワープさせてかなしばりにする"));
            itemList.Add(new DtoItem("氷柱の杖", 3, 800, 400, "正面3マスに10ターン氷柱を立てる"));
            itemList.Add(new DtoItem("ゴッドスパークの杖", 3, 10000, 5000, "100ダメージを与える"));
            itemList.Add(new DtoItem("転ばぬ先の杖", 3, 3000, 1400, "転ばせて、持っているアイテムを落とさせる"));
            itemList.Add(new DtoItem("ザキの杖", 3, 10000, 2500, "相手のHPを0にする"));
            itemList.Add(new DtoItem("砂柱の杖", 3, 800, 400, "正面3マスに10ターン砂柱を立てる"));
            itemList.Add(new DtoItem("とびつきの杖", 3, 800, 400, "光弾が当たったモンスター、壁、氷柱にとびつく"));
            itemList.Add(new DtoItem("ドルイドの杖", 3, 6000, 3000, "ワープさせて6~8行動分眠り状態にする"));
            itemList.Add(new DtoItem("トンネルの杖", 3, 500, 200, "光弾の当たった掘れる壁や水晶を10マス分破壊する"));
            itemList.Add(new DtoItem("バーサーカーの杖", 3, 3000, 1500, "50行動分バーサーカー状態になり、封印＋行動速度1ランク上昇状態になる"));
            itemList.Add(new DtoItem("場所替えの杖", 3, 800, 400, "光弾の当たった対象と位置を入れ替える"));
            itemList.Add(new DtoItem("バシルーラの杖", 3, 800, 400, "ワープさせる"));
            itemList.Add(new DtoItem("万能の杖", 3, 3000, 1500, "鉄化、氷結、レミーラ状態以外のステータス異常を解除する"));
            itemList.Add(new DtoItem("ピオリムの杖", 3, 2500, 1200, "行動速度を1ランク上昇させる"));
            itemList.Add(new DtoItem("ひきよせの杖", 3, 1200, 600, "光弾の当たったアイテム、モンスターを正面にひきよせる"));
            itemList.Add(new DtoItem("火柱の杖", 3, 800, 400, "正面3マスに10ターン火柱を立てる"));
            itemList.Add(new DtoItem("封印の杖", 3, 1500, 500, "封印状態にする"));
            itemList.Add(new DtoItem("ふきとばしの杖", 3, 1200, 600, "光弾が当たったキャラクターを5マスふきとばす"));
            itemList.Add(new DtoItem("分裂の杖", 3, 2500, 1200, "自キャラに当たると4~7行動分混乱させる"));
            itemList.Add(new DtoItem("へんげの杖", 3, 1000, 500, "そのフロアに出現するモンスターに変化させる"));
            itemList.Add(new DtoItem("ホイミの杖", 3, 500, 250, "HPを25回復させる"));
            itemList.Add(new DtoItem("ボミオスの杖", 3, 1200, 600, "行動速度を1ランク下げる"));
            itemList.Add(new DtoItem("マヌーサの杖", 3, 5000, 2500, "空振り状態にし、10行動分攻撃や隣接攻撃系特技が命中しなくなる"));
            itemList.Add(new DtoItem("丸得の杖", 3, 10000, 1, "HPの半分のダメージを与え、その分使用者のHPを回復させる"));
            itemList.Add(new DtoItem("身代わりの杖", 3, 2500, 1000, "対象を25行動分身代わり状態にする"));
            itemList.Add(new DtoItem("ミミックの杖", 3, 3000, 1500, "アイテム状態のミミックに変化させる"));
            itemList.Add(new DtoItem("メダパニの杖", 3, 1200, 250, "4~7行動分混乱状態にする"));
            itemList.Add(new DtoItem("もろはの杖", 3, 1000, 500, "使用者のHPが半分になり、対象のHPが1になる"));
            itemList.Add(new DtoItem("ようじゅつしの杖", 3, 4000, 2000, "おびえの杖、バシルーラの杖、ボミオスの杖のどれか1つの効果が発動する"));
            itemList.Add(new DtoItem("ラリホーの杖", 3, 1200, 400, "トルネコ、ポポロは4~5行動分、モンスターは6~9行動分眠り状態になる"));
            itemList.Add(new DtoItem("ルカニの杖", 3, 1200, 600, "防御力を1ランク下げる"));
            itemList.Add(new DtoItem("レミーラの杖", 3, 800, 400, "20行動分レミーラ状態になり、マップが全て埋まり敵の位置が表示され、フロアが明るくなる"));
            itemList.Add(new DtoItem("レムオルの杖", 3, 3000, 1200, "透明状態になり、目薬状態の相手にしか見えなくなる"));
            return itemList;
        }

        private List<DtoItem> GetItemListTsubo()
        {
            var itemList = new List<DtoItem>();
            itemList.Add(new DtoItem("インパスの壷", 4, 2000, 1200, "入れたアイテムが識別される"));
            itemList.Add(new DtoItem("うそつきの壷", 4, 10000, 2000, "入れたアイテムの名前が見るたびに変化する"));
            itemList.Add(new DtoItem("回復の壷", 4, 1000, 500, "押すと操作キャラクターのHPが全回復する"));
            itemList.Add(new DtoItem("火薬壷", 4, 4000, 2000, "割ると中身を周囲にばらまいた後に小爆発する"));
            itemList.Add(new DtoItem("草の神の壷", 4, 5000, 2000, "草を入れると、その草を投げ当てた場合の効果を視界内の全ての者にまき散らす"));
            itemList.Add(new DtoItem("合成の壷", 4, 3000, 1500, "入れたアイテムが合成可能だった場合合成される"));
            itemList.Add(new DtoItem("祝福の壷", 4, 3000, 1500, "入れたアイテムが祝福される"));
            itemList.Add(new DtoItem("すいこみの壷", 4, 5000, 1500, "押すと正面5マス以内にあるアイテムのうち一番近いものを吸い込む"));
            itemList.Add(new DtoItem("倉庫の壷", 4, 1000, 500, "入れたアイテムが倉庫に送られる"));
            itemList.Add(new DtoItem("大砲の壷", 4, 1000, 500, "入れたアイテムを遠投状態で発射することができる"));
            itemList.Add(new DtoItem("とじこめの壷", 4, 1500, 750, "投げ当てると当たった者を壷にとじこめ、壷は床に張り付く"));
            itemList.Add(new DtoItem("呪いの壷", 4, 3000, 1500, "入れたアイテムが呪われる"));
            itemList.Add(new DtoItem("ふつうの壷", 4, 1000, 500, ""));
            itemList.Add(new DtoItem("へんげの壷", 4, 5000, 1500, "入れたアイテムが他のアイテムに変化する"));
            itemList.Add(new DtoItem("保存の壷", 4, 1500, 750, "入れたアイテムを自由に取り出したり、入れた状態のまま使ったりすることができる"));
            itemList.Add(new DtoItem("魔法の壷", 4, 10000, 2000, "中に宝物アイテムが入っている　倉庫又は手元に、壷の中身と同じアイテムがあると「巻物のきれはし」になる"));
            itemList.Add(new DtoItem("まものの壷", 4, 3000, 1500, "押すとその階に出現するモンスターが周囲に出現する"));
            itemList.Add(new DtoItem("水がめ", 4, 1000, 500, "水路で水を汲み、汲んだ水をかけることができる"));
            itemList.Add(new DtoItem("ワープの壷", 4, 3000, 1500, "押すと操作キャラクターが吸い込まれて同じフロア内に落ちている他のワープの壷から出てくる"));
            return itemList;
        }
    }
}