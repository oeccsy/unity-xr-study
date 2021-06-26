# AR������ �� �߱�

��ư�� ������ AR������ ���� ����� ����� �����Ͽ���.

����� ������Ʈ�� ������ ����.

![Image](../SampleApp/App_AR_Study_1/Picture/ObjectList.png)

* Button - ��ư�� ������ Line�� ���⵵�� �Ѵ�.
* CenterPoint - Button�� ������ �� Line�� �����ϴ� ��ġ�� �����ִ� Point�̴�.
                Z���� 0.2~1.0 ��ŭ �����Ͽ� ������ ī�޶� ���� �տ��� �����ϵ��� �Ѵ�.
* LineManager - ���λ���/����/�ߴ� �� Line�� ���� �ϵ��� ���� ����� ������ ���� Object�̴�.
* LinePool - ������ �����Ǹ� �ش� Ǯ�� ��ϵǵ��� �Ѵ�.


## [LineRenderer]
3���� �������� �� �� �̻��� Position '�迭'�� �����ͼ� ������ Position ���̿� ������ �׸��� ������Ʈ�̴�.
3���� ������ ��ġ�ϴ� ������ �׸��� ���� ���ȴ�.

�ϳ��� ������Ʈ���� ������ �������̾�� �ϸ�, �� �� �̻��� �и��� ���� �׸����� ����
�� �� �̻��� ������Ʈ�� ����ؾ� �Ѵ�.

### [Line ����]

��ư�� ������ �� LineRenderer�� Line Object�� ���� ȭ�� �� ��쵵�� �Ѵ�.

```C#
    public void StartDrawLine()
    {
        _use = true;           
        if (!_startLine)
        {
            MakeLineRendere();
        }
    }
```
* Line ������ Line ����� �����ϱ� ���� _startLine ������ �̿��Ͽ�
  ��ư�� ������ �� ���� 1ȸ�� ���Ͽ� MakeLineRendere()�� ȣ��ǵ��� �Ѵ�.

```C#
    public void MakeLineRendere()
    {
        GameObject tLine = Instantiate(_lineRenderePrefabs);    //Line Object���� Line�� Prefab�� �̸� public ������ �����س��´�.
        tLine.transform.SetParent(_linePool);                   //Line�� �����Ǹ� LinePool�� �ڽ����� ����Ѵ�.
        tLine.transform.position = Vector3.zero;                
        tLine.transform.localScale = new Vector3(1, 1, 1);      //position,Scale�� �⺻ ����

        _lineRendere = tLine.GetComponent<LineRenderer>();      //LineRenderer�� �ʱ� ����
        _lineRendere.positionCount = 1;                         //Position�� 1���� ������ ���´�. 
        _lineRendere.SetPosition(0, _pivotPoint.position);
        
        _lineRendere.startColor = _nowColor;
        _lineRendere.endColor = _nowColor;

        _startLine = true;                                      //������ �̿��Ͽ� 1ȸ �����Ͽ����� ��Ÿ����.
        _lineList.Add(_lineRendere);

    }
```

### [Line ����]

��ư�� ���� ���·� �����ϸ� Line�� ����ؼ� ����ȴ�.

```C#
    void Update()
    {
        if (_use)
        {
            if (_startLine)
            {
                DrawLineContinue();
            }
        }
    }
```
* ��ư�� ������ ���� 1�����ӿ� ���Ͽ� ȣ����� �ʴ´�.

```C#
    public void DrawLineContinue()
    {
        _lineRendere.positionCount = _lineRendere.positionCount + 1;
        _lineRendere.SetPosition(_lineRendere.positionCount - 1, _pivotPoint.position);
    }
```
* Position �迭�� �÷����鼭 Line�� �����Ѵ�.

### [Line ���� �ߴ�]

��ư�� ���� ���¿��� ���� Line ������ �ߴܵȴ�.

```C#
    public void StopDrawLine()
    {
        _use = false;
        _startLine = false;
        _lineRendere = null;
    }
```

* _use = false; �� �Ͽ� DrawLineContinue() �� ���̻� ȣ����� �ʵ��� �Ѵ�.
* _startLine = flase; �� �Ͽ� �ٽ� ��ư�� ������ MakeLineRendere()�� 1ȸ ȣ��ǵ��� �Ѵ�.
* _lineRendere = null; �� �Ͽ� ������ �׸��� �ִ� Line�� ������ �����Ѵ�.






### [����ũ]
* https://www.youtube.com/watch?v=be1buuk-DKs (�ҽ��ڵ�)
* https://docs.unity3d.com/kr/530/ScriptReference/LineRenderer.html (LineRenderer)
* https://docs.unity3d.com/kr/2020.3/Manual/class-LineRenderer.html (LineRenderer)