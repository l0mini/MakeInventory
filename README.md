# Unity 인벤토리 시스템 프로젝트

Unity를 사용해 구현한 기본적인 인벤토리 시스템입니다.  
캐릭터 상태 표시, 아이템 장착/해제, 인벤토리 스크롤 및 슬롯 UI를 포함한 간단한 RPG 스타일의 기능을 갖추고 있습니다.

---

## 📌 주요 기능

### ✅ 메인 UI
- 메인 메뉴 버튼 구현
- UI 간 이동 가능

### ✅ 스탯 창 (Status UI)
- 캐릭터 이름, 레벨, 골드, 공격력/방어력/체력/치명타 등의 스탯을 표시
- 아이템 장착/해제 시 실시간으로 반영됨

### ✅ 인벤토리 UI
- 스크롤 가능한 슬롯 기반 UI
- 최대 슬롯 수 설정 가능 (기본 40개)
- 슬롯마다 아이콘 표시 및 장착 여부 표시

### ✅ 캐릭터 시스템
- `Character` 클래스에서 기본 스탯, 인벤토리, 장착된 아이템 관리
- 장착 아이템은 `Dictionary<ItemType, ItemData>`로 관리되어 각 타입 1개만 장착 가능

### ✅ 아이템 시스템
- 아이템은 `ItemData`로 구성
- 공격력, 방어력, 체력, 치명타 등 다양한 속성을 가짐

### ✅ 슬롯 & 장착 시스템
- 각 슬롯은 장착 버튼을 포함
- 장착된 아이템은 `E` 텍스트로 표시
- 버튼 클릭 시 장착/해제가 가능하며 스탯과 UI에 즉시 반영됨

---

## 🔧 구현 기술

- Unity 2022+
- TextMeshPro 사용
- Button, ScrollView, Image 등 기본 UI 요소 활용
- ScriptableObject로 데이터 분리
- Singleton 패턴으로 UI 및 GameManager 관리

---

## 🖼️ 스크린샷 (선택 사항)
> ![image](https://github.com/user-attachments/assets/8734efed-f61e-48a6-b9ea-79cb5afdbc6c)
