import logo from "./logo.svg";
import "./App.css";

function App() {
  return (
    <div className="App">
      <header className="App-header">
        <img src={logo} className="App-logo" alt="logo" />
        <p>React学習</p>
        <a
          className="App-link"
          href="https://ja.react.dev/learn"
          target="_blank"
          rel="noopener noreferrer"
        >
          Reactクイックスタート
        </a>
      </header>
      <br />
      <MyComponent />
      <br />
      野球チーム (Listに対してmapを使って出力)
      {listItems}
      <button onClick={handleClick}>onClickイベント</button>
    </div>
  );
}

function MyComponent() {
  return <div class="font-size-18">コンポーネント名は大文字で始まる</div>;
}

const teams = [
  { title: "読売ジャイアンツ", id: 1 },
  { title: "東京ヤクルトスワローズ", id: 2 },
  { title: "横浜DeNAベイスターズ", id: 3 },
  { title: "中日ドラゴンズ", id: 4 },
  { title: "阪神タイガース", id: 5 },
  { title: "広島東洋カープ", id: 6 },
];

const listItems = teams.map((team) => (
  <a
    class="team"
    href={"https://baseball.yahoo.co.jp/npb/teams/" + team.id + "/top"}
    target="_blank"
  >
    {team.title}
  </a>
));

function handleClick() {
  alert("You clicked me!");
}

export default App;
